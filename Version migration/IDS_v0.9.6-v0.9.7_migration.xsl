<?xml version="1.0"?>

<!--
 *
 * Author: 			Marcel Stepien, Andre Vonthron
 * Organisation: 	VSK Software GmbH
 * Date: 			2024.03.03
 * e-Mail: 			info@vsk-software.com
 * 
 * Applies transformation changes from IDS 0.9.6 to 0.9.7.
 *
-->

<xsl:stylesheet
        xmlns:ids="http://standards.buildingsmart.org/IDS"
        xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
        xmlns:xs="http://www.w3.org/2001/XMLSchema"
        version="1.0">

    <xsl:output method="xml" indent="yes"/>
    
	<xsl:template match="node()|@*">
	  <xsl:copy>
	    <xsl:apply-templates select="node()|@*"/>
	  </xsl:copy>
	</xsl:template>
	
	<!-- IDS-0.9.7: renaming property -> name to baseName -->
    <xsl:template match="ids:property/ids:name">
        <ids:baseName>
        	<xsl:apply-templates select="@*|node()" />
        </ids:baseName>
    </xsl:template>
	
	<!-- IDS-0.9.7: renaming datatype to dataType -->
	<xsl:template match="@datatype">
	   <xsl:attribute name="dataType">
	      <xsl:value-of select="."/>
	   </xsl:attribute>
	</xsl:template>
	
	<!-- 
		IDS-0.9.7: remove the min- and maxOccurs from the attribute facet and
		replace it with an enum of cardinalities of the interpreted occurs.
	 -->
    <xsl:template match="ids:requirements/*[@minOccurs = '1']">
    	<xsl:copy>
			<xsl:attribute name="cardinality">required</xsl:attribute>
    		<xsl:apply-templates select="node()|@*"/>
    	</xsl:copy>
    </xsl:template>
    <xsl:template match="ids:requirements/*[@minOccurs = '0' and @maxOccurs != '0']">
    	<xsl:copy>
			<xsl:attribute name="cardinality">optional</xsl:attribute>
    		<xsl:apply-templates select="node()|@*"/>
    	</xsl:copy>
    </xsl:template>
    <xsl:template match="ids:requirements/*[@minOccurs = '0' and @maxOccurs = '0']">
    	<xsl:copy>
			<xsl:attribute name="cardinality">prohibited</xsl:attribute>
    		<xsl:apply-templates select="node()|@*"/>
    	</xsl:copy>
    </xsl:template>
    
    <xsl:template match="ids:requirements/*[@minOccurs != '0' and @minOccurs != '1']">
    	<xsl:copy>
			<xsl:attribute name="cardinality">required</xsl:attribute>
    		<xsl:apply-templates select="node()|@*"/>
    	</xsl:copy>
    </xsl:template>
    
    <!-- removes the minOccurs and maxOccurs -->
    <xsl:template match="ids:requirements/*/@minOccurs" />
    <xsl:template match="ids:requirements/*/@maxOccurs" />
    
    
	<!-- 
		IDS-0.9.7: Adjustments to the partOf-facet. Including the removal of cardinality option of 'optional' (in replacement or required) and 
		the merged combination of IFCRELAGGREGATES and IFCRELFILLSELEMENT to one combined option. 
	-->
    <xsl:template match="ids:requirements/ids:partOf[@cardinality = 'optional']">
    	<xsl:copy>
			<xsl:attribute name="cardinality">required</xsl:attribute>
			<xsl:apply-templates select="node()|@*"/>
			
			<!--
				Important note! 
				Some xsl tranformer may require to exclude the modified attribute manually. 
				In that case replace the line above with the line below.
			-->
    		<!--  <xsl:apply-templates select="node()|@* except @cardinality"/> -->
    	</xsl:copy>
    </xsl:template>
    
    <xsl:template match="ids:requirements/ids:partOf[@relation = 'IFCRELVOIDSELEMENT' or @relation = 'IFCRELFILLSELEMENT']">
    	<xsl:copy>
			<xsl:attribute name="relation">IFCRELVOIDSELEMENT IFCRELFILLSELEMENT</xsl:attribute>
			<xsl:apply-templates select="node()|@*"/>
			
			<!--
				Important note! 
				Some xsl tranformer may require to exclude the modified attribute manually. 
				In that case replace the line above with the line below.
			-->
    		<!-- <xsl:apply-templates select="node()|@* except @relation"/>  -->
    	</xsl:copy>
    </xsl:template>
    
</xsl:stylesheet>
