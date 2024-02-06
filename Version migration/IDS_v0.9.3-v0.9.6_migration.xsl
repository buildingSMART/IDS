<?xml version="1.0"?>

<!--
 *
 * Author: 			Marcel Stepien, Andre Vonthron
 * Organisation: 	VSK Software GmbH
 * Date: 			2024.01.23
 * e-Mail: 			info@vsk-software.com
 * 
 * Applies transformation changes from IDS 0.9.3 to 0.9.6.
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
	    
	<!-- IDS-0.9.6: all partOf relations to uppercase -->
	<xsl:template match="@relation">
	    <xsl:attribute name="relation">
	        <xsl:value-of select="translate(., $lang_lower, $lang_upper)" />
	    </xsl:attribute>
	</xsl:template>
    
	<!-- IDS-0.9.6: renaming measure to datatype -->
	<xsl:template match="@measure">
	   <xsl:attribute name="datatype">
	      <xsl:value-of select="."/>
	   </xsl:attribute>
	</xsl:template>
	
	<!-- IDS-0.9.6: remove the min- and maxOccurs from the attribute facet -->
    <xsl:template match="attribute/@minOccurs" />
    <xsl:template match="attribute/@maxOccurs" />
    
</xsl:stylesheet>
