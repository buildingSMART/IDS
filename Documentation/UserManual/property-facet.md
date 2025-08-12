# Property facet

IFC **Properties** are the most common way to attach data to objects in IFC, and likely the most used IDS facet.

**Properties** are identified by a name (**BaseName** in IDS), such as "FireRating", and are grouped into **Property Sets**, such as "Pset_WallCommon" that help keep them organised by similar subject matters. IFC Properties have **Values**, which are of particular types, which, if relevant, express units.

buildingSMART provides standardised **Property Sets** and **Properties** to help seamless data exchange, by mandating the name, set and data type. For example:

| baseName             | propertySet           | dataType                         |
| -------------------- | ---------------------- | ------------------------------ |
| ThermalTransmittance | Pset_WallCommon        | IFCTHERMALTRANSMITTANCEMEASURE |
| FireRating           | Pset_WallCommon        | IFCLABEL                       |
| Length               | Qto_WallBaseQuantities | IFCLENGTHMEASURE               |

Users can also define custom **Properties** and **Property Sets**, which may be unique to the project or distributed using the **Property Set** templates feature of IFC. Naturally, it is encouraged to require **Properties** that are standardised by buildingSMART before inventing custom ones.

All standardised **Property Sets** start with the reserved prefixes "Pset_" or "Qto_"; these prefixes are prohibited for custom properties.

Standardised **Properties** apply to different entities. For example, some properties such as **LoadBearing** can be applied to walls, columns, and beams, but not furniture, ducts, or cables.
This is known as the **Applicable Entity**.
When specifying **Properties** in an IDS, it is important to consider which objects they can apply to.
All sorts of objects can have **Properties** applied, not only physical objects like doors, windows, and slabs, but also non-physical objects like tasks, materials, structural profile cross sections, or labour resources.

A special kind of **Property** is known as a **Quantity**. Whereas **Properties** refer to any arbitrary information about an object, **Quantities** refer specifically to calculated dimensions of the object, such as length, width, height, surface area, or net volume.
IFC makes a distinction between **Properties** and **Quantities**, but in IDS they are interchangeable, and you are allowed to specify **Quantities** just the same as a **Property** with this facet.
Just like **Properties**, **Quantities** are grouped into **Quantity Sets** and have a **Value**.

To see what **Properties** are standardised by buildingSMART, check the following lists below.
You will see a list of **Property Sets**. Clicking on a **Property Set** will bring you to its page,
which will show the **Applicable Entity** just below the page title, as well as a table of **Property Names** and expected data types for the **Values** and have an **Applicable Entity**.

- [IFC4X3_ADD2 Property and Quantity Sets](http://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/annex-b3.html)
- [IFC4 Property Sets](https://standards.buildingsmart.org/IFC/RELEASE/IFC4/ADD2_TC1/HTML/link/alphabeticalorder-property-sets.htm)
- [IFC4 Quantity Sets](https://standards.buildingsmart.org/IFC/RELEASE/IFC4/ADD2_TC1/HTML/link/alphabeticalorder-quantity-sets.htm)
- [IFC2X3 Property Sets](https://standards.buildingsmart.org/IFC/RELEASE/IFC2x3/TC1/HTML/psd/psd_index.htm)

Note that IFC2X3 only has buildingSMART standardised properties, not quantities.

Instead of checking the documentation, your IDS authoring software may help you to shortlist valid **Property Sets**.

## Supported types of properties

There are various types of properties in IFC. The IDS allows specifying simple [single values](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcPropertySingleValue.htm), [bounded values](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcPropertyBoundedValue.htm), [lists](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcPropertyListValue.htm), [tables](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcPropertyTableValue.htm), and [enumerations](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcPropertyEnumeratedValue.htm), while [~~complex properties~~](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcComplexProperty.htm) and [~~reference values~~](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcPropertyReferenceValue.htm) are not supported by IDS.

The interpretation of a list, table, bounded and enumerated property changes depending on the IDS requirement as follows:

- If the IDS value is a single value, at least one of the IFC values should match.
- If the IDS value is a restriction (with minExclusive,maxExclusive,minInclusive,maxInclusive), all IFC values should respect the range.

Because IFC bounded value properties can be limited on one end only, for them to meet IDS requirements, they must be entirely within the IDS restriction range. For example:

| IDS value | IFC Lower Bound | IFC Upper Bound | Expected Result | Reason                                                                               |
| :-------: | :-------------: | :-------------: | :-------------: | ------------------------------------------------------------------------------------ |
| >2 and ≤5 |        3        |        4        |      ✔️       | Both lower and upper bound are within the specified range                            |
| >2 and ≤5 |                 |        4        |       ❌      | The lower bound potentially extends below the minimum value of the restriction       |
| >2 and ≤5 |        3        |                 |       ❌      | The upper bound potentially extends above the maximum value of the restriction       |
| >2 and ≤5 |        2        |        3        |       ❌      | The lower bound is invalid because the restriction is exclusive of the minimum range |
| >2 and ≤5 |        3        |        5        |      ✔️       | The higher bound is valid because the restriction is inclusive of the maximum range  |
|     3     |        2        |        4        |      ✔️       | The lower and upper bounds include the specified value                               |
|     2     |        2        |        4        |      ✔️       | The lower bound matches the specified value                                          |
|     2     |        2        |                 |      ✔️       | The only provided bound is compatible with the specified value                       |
|     2     |                 |        2        |      ✔️       | The only provided bound is compatible with the specified value                       |
|     5     |        2        |        4        |       ❌      | The lower and upper bounds exclude the specified value                               |
|     5     |                 |        4        |       ❌      | The only provided bound is not compatible with the specified value                   |
| >2 and ≤5 |                 |                 |       ❌      | at least one of the lower and upper bounds is required                               |
|     3     |                 |                 |       ❌      | at least one of the lower and upper bounds is required                               |
|           |        2        |                 |      ✔️       | No value comparison is performed, and at least one value is provided                 |

## Property data types

In IDS facets, **Properties** may have a data type that constrains the expected format in which the property will be stored (e.g. text value, a boolean, or a number).
If it is a number, the value will be unit-less, such as a count of a value and the unit dependent on the measure associated with the specified `dataType`.
Our [unit documentation](units.md) provides the list of acceptable measures and the SI unit used for their expression. For more information, consult the IFC documentation at the following links:

- [IFC4X3_ADD2 data types](http://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/annex-b2.html)
- [IFC4 data types](https://standards.buildingsmart.org/IFC/RELEASE/IFC4/ADD2_TC1/HTML/link/alphabeticalorder-defined-types.htm)
- [IFC2X3 data types](https://standards.buildingsmart.org/IFC/RELEASE/IFC2x3/TC1/HTML/alphabeticalorder_definedtype.htm)

For convenience, a short list of common data types is here:

| Data type        | Usage Scenario                                                                             |
| ---------------- | ------------------------------------------------------------------------------------------ |
| IFCLABEL         | Most simple text values intended to be read by a human                                     |
| IFCIDENTIFIER    | An identification code intended to be read by computers, typically generated by a computer |
| IFCTEXT          | Lengthy descriptions to be read by humans                                                  |
| IFCBOOLEAN       | True or false (also sometimes known as yes / no) choices                                   |
| IFCINTEGER       | Arbitrary integers, such as 1, 2, 3, etc.                                                  |
| IFCREAL          | Arbitrary numbers, such as 1, 2, 3.14, etc                                                 |
| IFCCOUNTMEASURE  | An integer used to count a quantity of something                                           |
| IFCLENGTHMEASURE | A floating point number used to measure the physical length of something                   |
| IFCAREAMEASURE   | A floating point number used to measure the physical area of something                     |
| IFCVOLUMEMEASURE | A floating point number used to measure the physical volume of something                   |
| IFCDATE          | The date when something will or has happened, such as 2020-01-01                           |
| IFCDURATION      | A time duration, such as 3 months, 1 week, 4 days, or 1 hour.                              |

IDS currently specifies all measure-based values based on SI units. You can see the full list of units specified for each data type in the [IDS units table](units.md).
Note that although you can use a data type to request a particular measurement (e.g. an IFCLENGTHMEASURE), you cannot use IDS to request that the length is measured with a particular unit (e.g. meters, inches, or millimetres).

Properties are critical in providing supplementary information to objects in a model.

It is encouraged to follow buildingSMART standardised **Properties** wherever possible to ensure that data is highly structured and can be predictably retrieved.

## Parameters

| Parameter       | Required | Restrictions Allowed | Meaning                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| --------------- | -------- | -------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **propertySet** | ✔️     | ✔️                 | Any standard IFC or custom property set name (text). Standardised names must begin with "Pset_" or "Qto_" and can be found in the IFC documentation.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| **baseName**    | ✔️     | ✔️                 | Any standard or custom property name (text). Standardised buildingSMART property names can be found in the IFC documentation and bSDD. The property must exist in the specified property set and have a non-empty value.                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| **dataType**    | ❌       | ✔️                 | A valid data type compatible with the referenced schema version, expressed in UPPERCASE. The units specified in the IDS use the [IDS units table](units.md), though the project may use any unit, so project values will have to be converted to the SI unit before comparison. User Interfaces are permitted to display any unit that the developers or the users prefer.                                                                                                                                                                                                                                                                                                                         |
| **value**       | ❌       | ✔️                 | Any value appropriate to the data type of the property. If not specified, any non-empty value is allowed. The value of measure types will be stored according to the unit defined in the [IDS units table](units.md). The value of the property must match; see [DataType documentation](../ImplementersDocumentation/DataTypes.md#xml-base-types) for more information.                                                                                                                                                                                                                                                                                                                          |
| **uri**         | ❌       | ❌                   | Uniform Resource Identifier of the property. Used to reference a standardised definition of a property, to ensure consistency of interpretation. The target resource should include a name and definition, and preferably comply with the ISO 12006-3 and ISO 23386. This is an optional attribute that is not subject to IDS checking - the IFC model does not need to have the same or any URI. One source of valid URIs is [the bSDD](https://search.bsdd.buildingsmart.org/), and an example URI is that of a "Fire Rating": [https://identifier.buildingsmart.org/uri/buildingsmart/ifc/4.3/prop/FireRating](https://identifier.buildingsmart.org/uri/buildingsmart/ifc/4.3/prop/FireRating). |
|                 |          |                      |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |

## Examples

| Applicability Intention                                                                                                      | Requirement Intention                                                                                                                            | Facet Definition                                                                                    |
| ---------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------ | --------------------------------------------------------------------------------------------------- |
| Any wall entity with an acoustic rating                                                                                      | The entity (e.g. wall) must have an acoustic rating                                                                                              | Property Set="Pset_WallCommon", Name="AcousticRating"                                              |
| Any column entity with a fire rating of "2HR"                                                                             | The entity (e.g. column) must have a fire rating of "2HR"                                                                                        | Property Set="Pset_ColumnCommon", Name="FireRating", value="2HR"                                   |
| Any slab entity with a net volume between 20-100 cubic meters                                                                | The entity (e.g. slab) must have a net volume between 20-100 cubic meters                                                                        | Property Set="Qto_SlabBaseQuantities", Name="NetVolume", Value="[20<=Value<=100](restrictions.md)" |
| Any in-situ or precast concrete element                                                                                      | The entity (e.g. slab) must have a casting method set either to in-situ or precast                                                               | Property Set="Pset_ConcreteElementGeneral", Name="CastingMethod", value=["INSITU", "PRECAST"]      |
| Any entity with our custom property called ConcreteMix chosen from A, B, or C stored in our MyCompany_Concrete property set | The entity must have a custom property called ConcreteMix with a value chosen from A, B, or C stored in a property set named MyCompany_Concrete | Property Set="MyCompany_Concrete", Name="ConcreteMix", value=["A", "B", "C"]                       |


## Properties

### Required fields

Both `propertySet` and `baseName` are mandatory. Both `dataType*` and `value` are optional, but if `value` is provided, it also requires `dataType*`. The optional attribute `uri` is only metadata, not subject to IDS checking.

## Property facet interpretation

### Applicability

| Property Set | Base Name | Data Type* | Value | IDS Interpretation                                                                                          |
| ------------ | --------- | ---------- | ----- | ----------------------------------------------------------------------------------------------------------- |
| My_Set       | My_Prop   | -          | -     | Applies to all entities having a property *My_Prop* in the set *My_Set* filled in, regardless of the value. |
| My_Set       | My_Prop   | IFCTEXT    | Test  | Applies to all entities having a property *My_Prop* in the set *My_Set* with a valye *Test*.                |

### Requirements

| IDS Cardinality | Property Set | Base Name | Data Type* | Value | Configuration Allowed? | IDS Interpretation                                                                                                                    |
| --------------- | ------------ | --------- | ---------- | ----- | ---------------------- | ------------------------------------------------------------------------------------------------------------------------------------- |
| REQUIRED        | My_Set       | My_Prop   | -          | -     | ✅                     | Applicable objects need to have the property *My_Prop* in the *My_Set*.                                                               |
| REQUIRED        | My_Set       | My_Prop   | IFCTEXT    | -     | ✅                     | (as above) + of data type *IFCTEXT*.                                                                                                  |
| REQUIRED        | My_Set       | My_Prop   | IFCTEXT    | Test  | ✅                     | (as above) + of value *Test*.                                                                                                         |
| REQUIRED        | My_Set       | My_Prop   | -          | Test  | ❌                     | Not allowed. If a value is specified, it requires specification of a data type.                                                         |
| OPTIONAL        | My_Set       | My_Prop   | -          | -     | ❌                     | Optionality does not make sense - no added field to require.                                                                          |
| OPTIONAL        | My_Set       | My_Prop   | IFCTEXT    | -     | ✅                     | If applicable object have the property *My_Prop* in *My_Set* set, it needs to be an *IFCTEXT* data type. Lack of property is allowed. |
| OPTIONAL        | My_Set       | My_Prop   | IFCTEXT    | Test  | ✅                     | (as above) + have the value equal *Test*. Lack of property is allowed.                                                                |
| OPTIONAL        | My_Set       | My_Prop   | -          | Test  | ❌                     | Not allowed. If a value is specified, it requires specification of a data type.                                                         |
| PROHIBITED      | My_Set       | My_Prop   | -          | -     | ✅                     | The property *My_Prop* must not exist, regardless of the value, even if empty.                                                        |
| PROHIBITED      | My_Set       | My_Prop   | IFCTEXT    | -     | ❌                     | Not allowed. Either prohibit the whole property or specify values with REQUIRED/OPTIONAL.                                                 |
| PROHIBITED      | My_Set       | My_Prop   | IFCTEXT    | Test  | ❌                     | Not allowed. Either prohibit the whole property or specify values with REQUIRED/OPTIONAL.                                                 |
| PROHIBITED      | My_Set       | My_Prop   | -          | Test  | ❌                     | Not allowed. If a value is specified, it requires specification of a data type.                                                         |

<!-- For an evaluation of the rationale, see [these minutes](https://github.com/buildingSMART/IDS/issues/206#issuecomment-1820696088). -->
\* The field is an XML attribute
