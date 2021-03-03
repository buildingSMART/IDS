
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
So in example 1, the applicability is for IfcWalls that have a classifcationReference with a value of '21.22'. 
Selections and values for Requirements with 'OR' will be in the second production version. 

```
specification;  with user defined name
 applicability
    IF entity AND ClassificationReference
      THEN  'Selection' has to have:
			entity, property, with propertysetName, propertyName, allowed value, etc.
			AND
			Another property, material, classifcationReference, etc.
```

The IDS structure follows a simplified version of IFC where IFC Attributes, Properties and Material are directly connected to objects.
This 'ifc lite' is not an offical serialisation but makes the IDS more consistent when used with multiple IFC versions. 
 
The IDS structure looks like this: 
```xml
<specification name="">
  <applicability>
		<entity><name></name><predefinedtype></predefinedtype></entity>
		<classification><system></system><value></value></classification>
	  	<property><propertyset></propertyset><name></name><value></value></property>
		<material><value></value></material>
    </applicability>
    <requirements>
		<entity><name></name><predefinedtype></predefinedtype></entity>
		<classification href=""><system href=""></system><value></value></classification>
	    	<property href=""><propertyset></propertyset><name></name><value></value></property>
		<material href=""><value></value></material>
    </requirements>
</specification>
```

The <applicability> and <requirements> elements have the same content classification, property and material. Entity is only in the 'applicability' part.
All elements in applicability and requirements should be treated as 'AND'. 
In <requirements> there can only be one entity node (it can have multiple IFC Entities listed using xsd patterns; see stage 3 of the roadmap).


## Example 1: AedesUVIP

```xml
<specification name="vaste wand, othername">
	<applicability>
			<entity>
				<name>IfcWall</name>
			</entity>
			<classification>
				<system>NL-Sfb</system>
				<value>21.22</value>
			</classification>
	</applicability>
	<requirements>
		<property href="http://identifier.buildingsmart.org/uri/buildingsmart/ifc-4.3/prop/FireRating">
			<propertyset>AedesUVIP</propertyset>
			<name>Firerating</name>
			<value>
				<xs:restriction base="xs:string">
					<xs:enumeration value="30" />
					<xs:enumeration value="60" />
					<xs:enumeration value="90" />
				</xs:restriction>
			</value>
		</property>
	</requirements>
</specification>
```

Explaining this example:
Every 'specification' has a 'applicability' part and a 'requirements' part. 
The applicability is a list of applicabilitys that need to be applied to the IFC data. 
All things need to be fullfilled in the applicability. So in example 1, the applicability is for IfcWalls that have a classifcationReference with a value of '21.22'. 
 
In this example every IfcWall object that has an classification with the value '21.22' needs to have a (user defined) property with the name 'Firerating', that Firerating property should be in the propertyset named 'AedesUVIP' and the values of that Firerating property can be 30, 60 or 90.
There can be other properties in the propertyset, and there can be other properties in other property sets as well, but the property 'Firerating' needs to be there, and can only have one of the three values. 
In this example, more information about the property can be found on the provided URI. 

Walls with this value for classification are called 'vaste wand' or 'othername'. End users will see 'vaste wand' and know that they need to model that as an IfcWall with classification value 21.22 and the listed property (with allowed values).

Note: The values in 'entity' can only hold entity names of the IFC for which the IDS is defined. It can only hold specialisations of IfcObject.
In other words, an IDS is defining requirements for an IFC dataset that is delivered in a specific IFC version. The version of IFC is also defined in the IDS (general section).

## Example 2: Anas

```xml
<specification name="binder">
	<applicability>
		<entity>
			<name>IfcCovering</name>
			<predefinedtype>CLADDING</predefinedtype>
		</entity>
	</applicability>
	<requirements>
		<property>
			<propertyset>Anas</propertyset>
			<name>Codice WBS</name>
		</property>
		<material use="optional">
			<value>
				<xs:restriction base="xs:string">
					<xs:enumeration value="Concrete" />
					<xs:enumeration value="Wood" />
					<xs:enumeration value="Other" />
				</xs:restriction>
			</value>
		</material>
	</requirements>
</specification>
```

In this example every IfcCovering with predefined type 'CLADDING' should have a property called 'Codice WBS' that is in the propertyset 'Anas'.
Claddings with this property are called 'binder'. Users will be able to see how they should model a 'binder' and what properties need to be added to the object. 

Note: The values in 'predefinedtype' can only hold standardized predefined type values from the IFC standard.


