# Developer guide

**Warning: IDS is not yet formally released.**

An IDS file is simply an XML file, with its schema defined in XSD. You may open any existing IDS file and inspect its contents to get a feel for how an IDS is structured.

An IDS is considered valid if it passes the XSD-based validation check. All sample IDS files available in the buildingSMART directory of public IDS templates are guaranteed to be valid.

 - [Download the latest IDS v0.6 XSD schema](https://github.com/buildingSMART/IDS/blob/master/Development/0.6/ids_06.xsd)
 - [Download sample IDS files from the directory of public IDS templates](todo)

There are many freely available online tools and programming libraries that can perform XSD validation. Here is [one such XSD validation tool](https://www.liquid-technologies.com/online-xsd-validator) to save you an online search.

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

## Checking IDS against IFC

### PartOf Facet

Various versions of the IfcSchema allow several relationships; of these only 4 are valid for IDS, as higlighted in the table below.

The identification of `IfcRelationship` instances must comply with the type constraint identified in the `Relation` parameter, and
they will have to point to the entity under test via the __related attribute__ in the table below.

Any constraint in the `Entity` attribute of the facet, will be tested against the __relating attribute__ entity listed below.


| Relation type                               |  Valid  | Related attribute name         | Relating attribute name      | IFC Schemas and notes      |
|---------------------------------------------|---------|--------------------------------|------------------------------|----------------------------|
| IfcRelAssigns  (abstract)                   |         |                                |                              |                            |
|   IfcRelAssignsToActor                      |         | RelatedObjects                 | RelatingActor                | 2x3, 4, 4x3                |
|   IfcRelAssignsToControl                    |         | RelatedObjects                 | RelatingControl              | 2x3, 4, 4x3                |
|   IfcRelAssignsToGroup                      |   ✔    | RelatedObjects                 | RelatingGroup                | 2x3, 4, 4x3                |
|     IfcRelAssignsToGroupByFactor            |         | RelatedObjects                 | RelatingGroup                | 2x3, 4, 4x3                |
|   IfcRelAssignsToProcess                    |         | RelatedObjects                 | RelatingProcess              | 2x3, 4, 4x3                |
|   IfcRelAssignsToProduct                    |         | RelatedObjects                 | RelatingProduct              | 2x3, 4, 4x3                |
|   IfcRelAssignsToResource                   |         | RelatedObjects                 | RelatingResource             | 2x3, 4, 4x3                |
| IfcRelAssociates  (abstract)                |         | RelatedObjects                 |                              |                            |
|   IfcRelAssociatesApproval                  |         | RelatedObjects                 | RelatingApproval             | 2x3, 4, 4x3                |
|   IfcRelAssociatesClassification            |         | RelatedObjects                 | RelatingClassification       | 2x3, 4, 4x3; use classification facet instead |
|   IfcRelAssociatesConstraint                |         | RelatedObjects                 | RelatingConstraint           | 2x3, 4, 4x3                |
|   IfcRelAssociatesDocument                  |         | RelatedObjects                 | RelatingDocument             | 2x3, 4, 4x3                |
|   IfcRelAssociatesLibrary                   |         | RelatedObjects                 | RelatingLibrary              | 2x3, 4, 4x3                |
|   IfcRelAssociatesMaterial                  |         | RelatedObjects                 | RelatingMaterial             | 2x3, 4, 4x3; use material facet instead |
| 	IfcRelAssociatesProfileDef                |         | RelatedObjects                 | RelatingProfileDef           | 4x3                        |
| IfcRelConnects  (abstract)                  |         |                                |                              |                            |
|   IfcRelConnectsElements                    |         | RelatedElement                 | RelatingElement              | 2x3, 4, 4x3                |
|     IfcRelConnectsPathElements              |         | RelatedElement                 | RelatingElement              | 2x3, 4, 4x3                |
|     IfcRelConnectsWithRealizingElements     |         | RelatedElement                 | RelatingElement              | 2x3, 4, 4x3                |
|   IfcRelConnectsPorts                       |         | RelatedPort                    | RelatingPort                 | 2x3, 4, 4x3                |
|   IfcRelConnectsPortToElement               |         | RelatedElement                 | RelatingPort                 | 2x3, 4, 4x3                |
|   IfcRelConnectsStructuralActivity          |         | RelatedStructuralActivity      | RelatingElement              | 2x3, 4, 4x3                |
|   IfcRelConnectsStructuralMember            |         | RelatedStructuralConnection    | RelatingStructuralMember     | 2x3, 4, 4x3                |
|     IfcRelConnectsWithEccentricity          |         | RelatedStructuralConnection    | RelatingStructuralMember     | 2x3, 4, 4x3                |
|   IfcRelContainedInSpatialStructure         |   ✔    | RelatedElements                | RelatingStructure            | 2x3, 4, 4x3                |
|   IfcRelCoversBldgElements                  |         | RelatedCoverings               | RelatingBuildingElement      | 2x3, 4, 4x3                |
|   IfcRelCoversSpaces                        |         | RelatedCoverings               | RelatingSpace                | 2x3, 4, 4x3; RelatingSpace was called RelatedSpace in 2x3; this relationship is deprecated in Ifc4 and Ifc4x3 |
|   IfcRelFillsElement                        |         | RelatedBuildingElement         | RelatingOpeningElement       | 2x3, 4, 4x3                |
|   IfcRelFlowControlElements                 |         | RelatedControlElements         | RelatingFlowElement          | 2x3, 4, 4x3                |
|   IfcRelInterferesElements                  |         | RelatedElement                 | RelatingElement              | 4, 4x3                     |
|   IfcRelReferencedInSpatialStructure        |         | RelatedElements                | RelatingStructure            | 2x3, 4, 4x3                |
|   IfcRelSequence                            |         | RelatedProcess                 | RelatingProcess              | 2x3, 4, 4x3                |
|   IfcRelServicesBuildings                   |         | RelatedBuildings               | RelatingSystem               | 2x3, 4, 4x3; Relationship deprecated in Ifc4x3 |
|   IfcRelSpaceBoundary                       |         | RelatedBuildingElement         | RelatingSpace                | 2x3, 4, 4x3                |
|     IfcRelSpaceBoundary1stLevel             |         | RelatedBuildingElement         | RelatingSpace                | 2x3, 4, 4x3                |
|       IfcRelSpaceBoundary2ndLevel           |         | RelatedBuildingElement         | RelatingSpace                | 2x3, 4, 4x3                |
| IfcRelDeclares                              |         | RelatedDefinitions             | RelatingContext              | 4, 4x3                     |
| IfcRelDecomposes  (abstract)                |         |                                |                              |                            |
|   IfcRelAggregates                          |    ✔   | RelatedObjects                 | RelatingObject               | 2x3, 4, 4x3                |
|   IfcRelNests                               |    ✔   | RelatedObjects                 | RelatingObject               | 2x3, 4, 4x3                |
|   IfcRelProjectsElement                     |         | RelatedFeatureElement          | RelatingElement              | 2x3, 4, 4x3                |
|   IfcRelVoidsElement                        |         | RelatedOpeningElement          | RelatingBuildingElement      | 2x3, 4, 4x3                |
|   IfcRelAdheresToElement                    |         | RelatedSurfaceFeatures         | RelatingElement              | 4x3                        |
| IfcRelDefines  (abstract)                   |         |                                |                              |                            |
|   IfcRelDefinesByObject                     |         | RelatedObjects                 | RelatingObject               | 2x3, 4, 4x3                |
|   IfcRelDefinesByProperties                 |         | RelatedObjects                 | RelatingPropertyDefinition   | 2x3, 4, 4x3; use property facet instead |
|   IfcRelDefinesByTemplate                   |         | RelatedPropertySets            | RelatingTemplate             | 4, 4x3                     |
|   IfcRelDefinesByType                       |         | RelatedObjects                 | RelatingType                 | 2x3, 4, 4x3                |

### Test suites

Any software implementing IDS checking **must** comply with the following test suites.

 - [Overall integration testscases](testcases-validation.md)
 - [Entity testcases](testcases-entity.md)
 - [Attribute testcases](testcases-attribute.md)
 - [Classification testcases](testcases-classification.md)
 - [Property testcases](testcases-property.md)
 - [Material testcases](testcases-material.md)
 - [PartOf testcases](testcases-partof.md)

## Generating reports from IDS results

TODO: specify rules about BCF

## Handling IFC compatibility

If the software is not capable of parsing the specified IFC version nominated by the IDS specification, then the user should be made aware of the limitation.

## Handling different IDS versions

IDS is not yet formally released and so there is no guarantee of vendor support for any IDS version.

## Available developer libraries

To help you get started with development, here is a directory of IDS libraries that you may use in your application. Please feel free to [submit your library](https://github.com/buildingSMART/IDS/pulls).

Language | License | Library
--- | --- | ---
C# | ? | [XBim](todo)
Python | LGPL-3.0-or-later | [IfcOpenShell](todo)
? | ? | ODA?
Javascript | ? | Something or other

## More reading

 - [Add your implementation to the software vendors directory](https://technical.buildingsmart.org/resources/software-implementations/)
 - [Make a suggestion for improvement](https://github.com/buildingSMART/IDS/issues)
