
# Examples 1st production release


## Features for first production version
 
 * Selection and requirements seperatly defined
 * IFC Entities
 * IFC Predefined Types (1)
 * IFC Classification References (1)
 * IFC Properties and Quanities (1)
 * Self defined Properties (1)
 * IFC Property set names (1)
 * Allowed values: Enumerations
 * References to external sources (URI, bSDD)
 * IFC Material (1)
 
(1) = this requires a definition of an 'ifc Lite' structure as well. 
During the implementation of the first production release there will be a focus on consistency and reliability between tools. 
Feedback will be used to fine-tune and tweak the XSD Schema and examples. 
 
# Examples
 
## Structure
 
Selection and Requirement elemens are 'AND'. 
So in example 1, the selection is for IfcWalls that have a classifcationReference with a value of '21.22'. 
Selections and values for Requirements with 'OR' will be in the second production version. 

<rule>
  <selection 'with user defined name'>
    IF <IfcEntity> AND <IfcClassificationReference>
    </selection>
   THEN  'Selection' has to have:
    <requirements>
	        <IfcProperty> 
	            <PropertySet>
	            <PropertyName>
	            <value>
    </requirements>
</rule>

## Example 1: AedesUVIP

<rule>
  <selection InformationUnitName="vaste wand, othername">
        <IfcEntity>IfcWall</IfcEntity>
        <IfcClassificationReference>
            <value>21.22</value>
        </IfcClassificationReference>
    </selection>
    <requirements>
	        <IfcProperty>
	            <PropertySet>AedesUVIP</PropertySet>
	            <Property ref="http://identifier.buildingsmart.org/uri/buildingsmart/ifc-4.3/prop/FireRating">Firerating</Property>
	            <value>
	                <xs:restriction base="xs:string">
	                    <xs:enumeration value="30" />
	                    <xs:enumeration value="60" />
	                    <xs:enumeration value="90" />
	                </xs:restriction>
	            </value>
	        </IfcProperty>
    </requirements>
</rule>

Explaining this example:
Every 'rule' has a 'selection' part and a 'requirements' part. 
The selection is a list of selections that need to be applied to the IFC data. 
All things need to be fullfilled in the selection. So in example 1, the selection is for IfcWalls that have a classifcationReference with a value of '21.22'. 
 
In this example every IfcWall object that has an IfcClassificationReference with the value '21.22' needs to have a (user defined) Property with the name 'Firerating', that Firerating property should be in the PropertySet named 'AedesUVIP' and the values of that Firerating property can be 30, 60 or 90.
There can be other properties in the PropertySet, and there can be other properties in other property sets as well, but the property 'Firerating' needs to be there, and can only have one of the three values. 
In this example, more information about the property can be found on the provided URI. 

Walls with this value for IfcClassificationReference are called 'vaste wand' or 'othername'. End users will see 'vaste wand' and know that they need to model that as an IfcWall with IfcClassificationReference value 21.22 and the listed Property (with allowed values).

Note: The values in 'ifcEntity' can only hold IfcEntity names of the IFC for which the IDS is defined. 
In other words, an IDS is defining requirements for an IFC dataset that is delivered in a specific IFC version. The version of IFC is also defined in the IDS (general section).

## Example 2: Anas

<rule>
  <selection InformationUnitName="binder">
        <IfcEntity>IfcCovering</IfcEntity>
        <PredefinedType>
            <value>CLADDING</value>
        </PredefinedType>
    </selection>
    <requirements>
	        <IfcProperty>
	            <PropertySet>Anas</PropertySet>
	            <Property>Codice WBS</Property>
	        </IfcProperty>
    </requirements>
</rule>

In this example every IfcCovering with PredefinedType 'CLADDING' should have a property called 'Codice WBS' that is in the PropertySet 'Anas'.
Claddings with this property are called 'binder'. Users will be able to see how they should model a 'binder' and what properties need to be added to the object. 

Note: The values in 'PredefinedType' can only hold standardized IFC values. User defined values are in the 'objectType' attribute.


