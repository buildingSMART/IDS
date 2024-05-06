# Developer guide

**Warning: IDS is not yet formally released.**

An IDS file is simply an XML file, with its schema defined in XSD. You may open any existing IDS file and inspect its contents to get a feel for how an IDS is structured.

An IDS is considered valid if it passes the XSD-based validation check. All sample IDS files available in the buildingSMART directory of public IDS templates are guaranteed to be valid.

1. [Download the latest IDS XSD schema](https://github.com/buildingSMART/IDS/blob/master/Development/ids.xsd)
2. Download sample IDS files from the `Documentation/testcases` folder

There are many freely available online tools and programming libraries that can perform XSD validation.
However a valid IDS file requires more thatn bare XML schema compliance; buildingSMART provides an [IDS auditing tool](https://github.com/buildingSMART/IDS-Audit-tool/) to help ensure that the IDS files that you produce or receive are fully valid. The same tool is also available at [Xbim IDS auditing service](https://www.xbim.it/ids), which is executed locally in your web browser and does not upload your IDS files to any server.

## Authoring IDS

If you are writing software to read and author IDS files only, you **must** meet the following criteria:

- All IDS software must read and write valid IDS files only.
- No proprietary extensions are allowed. If auxiliary systems (e.g. additional loaded metadata) are used to augment IDS or the correlating IFC model, they should be made clear to the user that it is external to IDS.
- No data loss shall occur. Loading an IDS and saving the IDS shall preserve all of its information. Minor syntax formatting changes are allowed, so long as the data remains unchanged.

In addition, it is highly recommended to also provide the following features for users:

- When users write an IFC class in an **Entity Facet**, your interface should restrict allowable values to valid IFC class names in the selected IFC schema for the specification. Autocompletion is recommended.
- When users write a predefined type in an **Entity Facet**, your interface should recommend allowable values based on the nominated IFC class. However, it should still allow users to write a custom predefined type. Autocompletion is recommended.
- When users have already specified an **Entity Facet** and are creating an **Attribute Facet**, your interface should restrict allowable values based on the nominated IFC class. Your interface should also guide the user to use the right data type based on the nominated attribute name.
- When users have already specified an **Entity Facet** and are creating a **Property Facet**, your interface should recommend allowable property sets based on the nominated IFC class and predefined type. However, it should also allow users to write a custom property set name. If a standardised (e.g. `Pset_` or `Qto_`) property set is nominated, your interface should restrict the allowable property names and recommend the appropriate data type to be used.
- When a string is specified for a custom property in a **Property Facet**, it is preferred for IfcLabel to be the default data type
- When an integer is specified for a custom property in a **Property Facet**, it is preferred for IfcInteger to be the default data type
- When a float is specified for a custom property in a **Property Facet**, it is preferred for IfcReal to be the default data type
- When a user is specifying a value with a unit, you should provide conversion tools so that the user can write the IDS in their preferred unit
- You may also choose to preload standardised classification names for commonly known systems, as well as the classification references to prevent spelling errors. You may choose to use this [IFC directory for classification systems](https://github.com/Moult/ifcclassification).
- When users are nominating a **Material Facet**, your interface should recommend the IFC recommended material categories (one of 'concrete', 'steel', 'aluminium', 'block', 'brick', 'stone', 'wood', 'glass', 'gypsum', 'plastic', or 'earth')
- When specifying values, the XML strings (for simpleValue and restriction enumeration) should conform to the [regular expressions](DataTypes.md#xml-base-types) presented in the [DataType documentation](DataTypes.md).

## Checking IDS against IFC

Any software implementing IDS checking **must** comply with the test suite of IFC/IDS pairs available in the `Documentation/testcases` folder (see [test cases documentation](testscases/scripts.md)).

In addition, it is highly recommended to also provide the following features for users:

- It is intended that IDS auditing results may be saved as BCF-XML format, or connect to an OpenCDE via the BCF-API. However, the formatting and overall structuring of these results in BCF are not specified right now.
- If the software is not capable of parsing the specified IFC version nominated by the IDS specification, then the user should be made aware of the limitation.
- If the requirement is optional but would fail if it were required instead, the checker tool must not log an error, but may offer auxiliary warnings or recommendations

### Precision

A float value is considered to be equivalent to a number `x`, if it lies between (exclusive) the range of `x * (1. - 1.e-6) - 1.e-6` and `x * (1. + 1.e-6) + 1.e-6`.

This is a compromise and simplification that allows precision to scale from small to large units.

### Restrictions

XSD also includes a **Total Digits** and a **Fraction Digits** restriction. These will not be supported in IDS as they have limited utility.

### Optionality

Specifications can be set to **Required**, **Optional**, or **Prohibited** depending on the required match of their `applicability` on the model. 
This is represented using XSD's `minOccurs` and `maxOccurs` functionality. They are represented by the following states:

| Optionality | minOccurs | maxOccurs |
| ----------- | --------- | --------- |
| Required    | 1         | unbounded |
| Optional    | 0         | unbounded |
| Prohibited  | 0         | 0         |

Other configurations of `minOccurs` and `maxOccurs` are currently not allowed.

## Available developer libraries

To help you get started with development, here is a directory of IDS libraries that you may use in your application. Please feel free to [submit your library](https://github.com/buildingSMART/IDS/pulls).

| Language | License           | Library                                      | Notes                                                               |
| -------- | ----------------- | -------------------------------------------- | ------------------------------------------------------------------- |
| C#/.NET  | CDDL              | [xbim Xids](https://github.com/CBenghi/Xbim.Xids) | A library to read, write data in IDS files                     |
| C#/.NET  | AGPL-3.0-only / commercial | [xbim Toolkit IDS Validator](https://github.com/xBimTeam/Xbim.IDS.Validator) | A complete IDS verification library for IFC models  |
| Python   | LGPL-3.0-or-later | [IfcOpenShell](https://ifcopenshell.org/)    |                                                                     |
| ?        | ?                 | ODA?                                         |                                                                     |

We welcome more libary contributors, feel free to propose a pull request, if you would like to update the list.

## More reading

- [Add your implementation to the software vendors directory](https://technical.buildingsmart.org/resources/software-implementations/)
- [Make a suggestion for improvement](https://github.com/buildingSMART/IDS/issues)
