
# Examples 1st production release


## Features for first production version
 
 * Selection and requirements seperatly defined
 * IFC Entities
 * IFC Predefined Types (1)
 * IFC Classification References (1)
 * IFC Properties and Quanities (1)
 * Self defined Properties (1)
 * IFC property set names (1)
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

```
selection 'with user defined name'
    IF entity AND ClassificationReference
      THEN  'Selection' has to have:
	        property, with propertysetName, propertyName, allowed value, etc.
			AND
			Another property, material, classifcationReference, etc.
```

The IDS structure follows a simplified version of IFC where IFC Attributes, Properties and Material are directly connected to objects.
This 'ifc lite' is not an offical serialisation but makes the IDS more consistent when used with multiple IFC versions. 
 
The IDS structure looks like this: 
```
<rule>
  <selection id="">
        <entity><name></name><type></type></entity>
	        <classification><system><value></value></system></classification>
		    <property><propertyset><value></value></propertyset></property>
			<material><value></value></material>
    </selection>
    <requirements>
	        <classification ref=""><system ref=""><value></value></system></classification>
		    <property ref=""><propertyset><value></value></propertyset></property>
			<material ref=""><value></value></material>
    </requirements>
</rule>
```

The <selection> and <requirements> elements have the same content classification, property and material. Entity is only in the 'selection' part.
All elements in selection and requirements should be treated as 'AND'. 


## Example 1: AedesUVIP

```
<rule>
  <selection id="vaste wand, othername">
        <entity>
		     <name>IfcWall</name>
		</entity>
        <classification>
		    <system>NL-Sfb</system>
            <value>21.22</value>
        </classification>
    </selection>
    <requirements>
	        <property>
	            <propertyset>AedesUVIP</propertyset>
	            <property ref="http://identifier.buildingsmart.org/uri/buildingsmart/ifc-4.3/prop/FireRating">Firerating</property>
	            <value>
	                <xs:restriction base="xs:string">
	                    <xs:enumeration value="30" />
	                    <xs:enumeration value="60" />
	                    <xs:enumeration value="90" />
	                </xs:restriction>
	            </value>
	        </property>
    </requirements>
</rule>
```

Explaining this example:
Every 'rule' has a 'selection' part and a 'requirements' part. 
The selection is a list of selections that need to be applied to the IFC data. 
All things need to be fullfilled in the selection. So in example 1, the selection is for IfcWalls that have a classifcationReference with a value of '21.22'. 
 
In this example every IfcWall object that has an classification with the value '21.22' needs to have a (user defined) property with the name 'Firerating', that Firerating property should be in the propertyset named 'AedesUVIP' and the values of that Firerating property can be 30, 60 or 90.
There can be other properties in the propertyset, and there can be other properties in other property sets as well, but the property 'Firerating' needs to be there, and can only have one of the three values. 
In this example, more information about the property can be found on the provided URI. 

Walls with this value for classification are called 'vaste wand' or 'othername'. End users will see 'vaste wand' and know that they need to model that as an IfcWall with classification value 21.22 and the listed property (with allowed values).

Note: The values in 'entity' can only hold entity names of the IFC for which the IDS is defined. 
In other words, an IDS is defining requirements for an IFC dataset that is delivered in a specific IFC version. The version of IFC is also defined in the IDS (general section).

## Example 2: Anas

```
<rule>
  <selection id="binder">
        <entity>
			<name>IfcCovering</name>
	        <type>CLADDING</type>
        </entity>
    </selection>
    <requirements>
	        <property>
	            <propertyset>Anas</propertyset>
	            <property>Codice WBS</property>
	        </property>
			<material optional="yes">
				<value>
	                <xs:restriction base="xs:string">
	                    <xs:enumeration value="Concrete" />
	                    <xs:enumeration value="Wood" />
	                    <xs:enumeration value="Other" />
	                </xs:restriction>
		        </value>
	        </material>
    </requirements>
</rule>
```

In this example every IfcCovering with type 'CLADDING' should have a property called 'Codice WBS' that is in the propertyset 'Anas'.
Claddings with this property are called 'binder'. Users will be able to see how they should model a 'binder' and what properties need to be added to the object. 

Note: The values in 'type' can only hold standardized IFC values.


