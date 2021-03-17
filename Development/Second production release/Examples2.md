
# Examples 2nd production release


## Features for second production version
 
Already in the first version
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

Now adding in the second version:
 * Allowed values: Adding label to allowed values
 * Allowed values: XML restrictions
 * Allowed Values: XML Patterns and/or Regular Expressions

 
# Examples
 
## Structure
 
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


## Example 3: advanced AedesUVIP 

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
				<xs:restriction use="optional" base="xs:string">
					<xs:enumeration label="Thirty minutes" value="30" />
					<xs:enumeration label="Sixty minutes" value="60" />
					<xs:enumeration label="Ninety minutes" value="90" />
				</xs:restriction>
			</value>
		</property>
	</requirements>
</specification>
```



## Example 4: Advanced Anas

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
			<value>
				<xs:restriction base="xs:integer">
				  <xs:minInclusive value="0"/>
				  <xs:maxInclusive value="120"/>
				</xs:restriction>
			</value>
		</property>
		<material use="optional">
			<value>
				<xs:restriction use="required" base="xs:string">
				      <xs:pattern value="[A-Z][A-Z]"/>
				</xs:restriction>
			</value>
		</material>
	</requirements>
</specification>
```



