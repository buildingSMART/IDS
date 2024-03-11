<?xml version="1.0"?>

<!--
 *
 * Author: 			Marcel Stepien
 * Organisation: 	VSK Software GmbH
 * Date: 			2024.02.07
 * e-Mail: 			info@vsk-software.com
 * 
 * Applies transformation of IDS developer agreements  changes from IDS 0.9.6 to 1.0.
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
	
    <xsl:param
	    name="lang_lower"
	    select="'abcdefghijklmnopqrstuvwxyz'" />
	    
	<xsl:param
	    name="lang_upper"
	    select="'ABCDEFGHIJKLMNOPQRSTUVWXYZ'" />
	    
	<!-- IDS-Audit: IFC2x3 schema hint in lower-case for the x only -->
	<xsl:template match="ids:specification/@ifcVersion">
	    <xsl:attribute name="ifcVersion">    	
		   <xsl:value-of select="translate(., $lang_lower, $lang_upper)"/>
	    </xsl:attribute>
	</xsl:template>
	
	<!-- IDS-Audit: IFC entity names are printed in upper-case -->
	<xsl:template match="ids:entity/ids:name/ids:simpleValue/text()">
	   <xsl:value-of select="translate(., $lang_lower, $lang_upper)"/>
	</xsl:template>
	
	<xsl:template match="ids:entity/ids:name/xs:restriction/xs:enumeration/@value">
	    <xsl:attribute name="value">    	
		   <xsl:value-of select="translate(., $lang_lower, $lang_upper)"/>
	    </xsl:attribute>
	</xsl:template>
	
	<!-- IDS-Audit: upper-case of datatype for version 0.9.6 -->
	<xsl:template match="ids:property/@datatype">
	    <xsl:attribute name="datatype">    	
		   <xsl:value-of select="translate(., $lang_lower, $lang_upper)"/>
	    </xsl:attribute>
	</xsl:template>
	
	<!-- IDS-Audit: upper-case of dataType for version 0.9.7 -->
	<xsl:template match="ids:property/@dataType">
	    <xsl:attribute name="dataType">    	
		   <xsl:value-of select="translate(., $lang_lower, $lang_upper)"/>
	    </xsl:attribute>
	</xsl:template>
	
	<!-- IDS-Audit: ensure that a base is provided for restrictions, but only if none is provided -->
	<xsl:template match="xs:restriction[(./xs:minInclusive or ./xs:maxInclusive or ./xs:minExclusive or ./xs:maxExclusive) and not(@base)]">
    	<xsl:copy>
			<xsl:attribute name="base">xs:double</xsl:attribute>
    		<xsl:apply-templates select="node()|@*"/>
    	</xsl:copy>
    </xsl:template>
    
    <xsl:template match="xs:restriction[(./xs:enumeration or ./xs:pattern) and not(@base)]">
    	<xsl:copy>
			<xsl:attribute name="base">xs:string</xsl:attribute>
    		<xsl:apply-templates select="node()|@*"/>
    	</xsl:copy>
    </xsl:template>
    
</xsl:stylesheet>
