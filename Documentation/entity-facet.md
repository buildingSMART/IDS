# Entity facet

Every instance in an IFC model has an "IFC Class" (also known as EXPRESS entity). For example, wall instances will have IFC class IfcWall, and door instances will have IFC class IfcDoor. Instances that don't represent individual building elements will also have a class. For example, project has class IfcProject, window types have class of IfcWindowType, and cost items have a class IfcCostItem.

Classes aren’t just for categorising instances. They also indicate what types of properties and relationships it is allowed to have. For example, an instance of IfcWall class can have a fire rating property, but an IfcGrid instance cannot.

Different IFC schemas have different IFC classes. More recent IFC schemas contain richer and more diverse IFC classes, which you can compare here:

- [IFC4X3 list of IFC class names](http://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/annex-b1.html)
- [IFC4 list of IFC class names](https://standards.buildingsmart.org/IFC/RELEASE/IFC4/ADD2_TC1/HTML/link/alphabeticalorder-entities.htm)
- [IFC2X3 list of IFC class names](https://standards.buildingsmart.org/IFC/RELEASE/IFC2x3/TC1/HTML/alphabeticalorder_entities.htm)

Some classes may also optionally have a **Predefined Type**. This is a further level of instance categorisation in addition to the IFC Class **Name**. For example, an instance of IfcWall may have a **Predefined Type** of SHEAR, or PARTITIONING. Whereas the IFC Class **Name** is specified by the IFC standard, the **Predefined Type** may also contain custom values by the user.

The IFC schema documentation contains a list of standard predefined types. Here is how you might find a list of valid **Predefined Types** for the IFC4X3 schema. The instructions will be similar for all IFC versions.

 1. Browse to the documentation page for the IFC class you are specifying. You can get there from the list of IFC class names above. For example, [this is the IfcWall documentation page](http://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcWall.htm).
 2. Scroll down to the **Attributes** section of the documentation and find the **PredefinedType** attribute.
 3. Click on the enumeration link next to the **PredefinedType** attribute to view the list of valid values. For example, for an IfcWall, you will click the link to bring you to [the documentation for IfcWallTypeEnum](http://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcWallTypeEnum.htm).
 4. A list of valid **Predefined Types** are shown in a table.

Choosing from the list of standardised **Predefined Types** is highly recommended. However, if they do not apply to your project you may specify any custom value. For example, you may specify "RADIATIONBARRIER" as a custom **PredefinedType** for an **IfcWall**.

One of the most important aspects of writing a specification is to ensure that it applies to the appropriate IFC class. Typically, every single **Specification** will have an **Entity Facet** used in its **Applicability** section.

## Parameters

| Parameter           | Required | Restrictions Allowed | Allowed Values                                                         | Meaning                                    |
| ------------------- | -------- | -------------------- | ---------------------------------------------------------------------- | ------------------------------------------ |
| **Name**            | ✔️     | ✔️                 | A valid IFC class from the IFC schema.                                 | The IFC Class must match exactly           |
| **Predefined Type** | ❌       | ✔️                 | A valid predefined type from the IFC schema, or any custom text value. | The IFC Predefined Type must match exactly |

## Examples

| Applicability Intention                                                                  | Requirement Intention         | Facet Definition                                         |
| ---------------------------------------------------------------------------------------- | ----------------------------- | -------------------------------------------------------- |
| All partition walls                                                                      | Must be a partition wall      | Name="IFCWALL", PredefinedType="PARTITIONING"            |
| All floor slabs                                                                          | Must be a floor slab          | Name="IFCSLAB", PredefinedType="FLOOR"                   |
| All door types, such that may be documented in a door types schedule                     | Must be a door type           | Name="IFCDOORTYPE"                                       |
| All building storeys                                                                     | Must be a building storey     | Name="IFCBUILDINGSTOREY"                                 |
| All related documents, such as drawings, schedules, manuals, and specifications          | Must be a document            | Name="IFCDOCUMENTINFORMATION"                            |
| All distribution systems, such as hot water systems, electrical circuits, etc            | Must be a distribution system | Name=["IFCDISTRIBUTIONSYSTEM", "IFCDISTRIBUTIONCIRCUIT"] |
| All construction tasks, such as in construction scheduling in a work breakdown structure | Must be a construction task   | Name="IFCTASK", PredefinedType="CONSTRUCTION"            |

## Special cases in IFC2X3

Some occurrence entities in IFC2X3 are further specified by their type object. 
An example is the definition of an air terminal, which is encoded in IFC2X3 by an occurrence instance of IfcFlowTerminal and a type instance of IfcAirTerminalType.
The entity facet does not have a parameter to further specify the type entity name.
In this case, the IDS follows the convention introduced in IFC4, which also makes the IDS-based check more schema-agnostic.
In the given example, the **name** of the entity to be checked should be IfcAirTerminal (without type) and must be resolved by a given mapping table. 
A full list is given in this [table](./Documentation/ifc2x3-occurrence-type-mapping-table.md)    