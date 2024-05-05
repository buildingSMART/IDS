# Attribute facet

Every entity in an IFC model has a list of standardised **Attributes**. **Attributes** are a limited set of fundamental data (usually less than 10) associated with all IFC entities. These are fixed by the IFC standard and cannot be customised.

Here are some common attributes and what they mean:

- **GlobalId**: a unique ID for the element useful for computer geeks
- **Name**: a short name, code, number, or label to identify the object for a human. If you had to annotate the object on a drawing or a schedule, the Name is what you should see. For example, a pump Name might be P-10-A.
- **Description**: typically the longer form of the name, written to be descriptive and readable for humans. For example a pump Description might be Water Suction Pump.
- **Tag**: this is an ID that may link it back to another BIM application. For example if the IFC model was produced using Revit or ArchiCAD, it might hold the Revit or ArchiCAD element ID.

Information that is not critical to the definition of the IFC entity is stored as a **Property**, not an **Attribute**. For more information view the documentation on the [**Property Facet**](property-facet.md).

For this reason, **Attributes** are a good way to specify an **Applicability** to specific elements, or specify a **Requirement** that certain elements shall be identified, named, or described in a particular way.

To see what **Attributes** are available for an IFC class and what their potential values may be, you will need to check the IFC documentation. Here is how you might find a list of valid **Attributes** for the IFC4X3 schema. The instructions will be similar for all IFC versions.

 1. Browse to the documentation page for the IFC class you are specifying. For example, [this is the IfcWall documentation page](http://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcWall.htm).
 2. Scroll down to the **Attributes** section of the documentation. Note that by default, not all attributes are shown. Press "_Click to show hidden inherited attributes_" to show all attributes. For IFC4, click on the "_Attribute inheritance_" text header to toggle a table for all attributes.
 3. The **Attributes** table will show the **Name** of each **Attribute**. Note that **Attributes** which do not have a number next to them and are in italics are not allowed to be specified. Only enumerated **Attributes** may be specified. For example, you may specify the **Name** attribute for an IfcWall, but you may not specify **ConnectedTo**.

Instead of checking the documentation, your IDS authoring software may help you to shortlist valid **Attributes**.

Following naming conventions and accurately describing elements are critical to many usecases in the AECO industry. For this reason, it is very common to use the **Attribute Facet** in both the **Applicability** and **Requirements** section of **Specifications**.

## Parameters

| Parameter | Required | Restrictions Allowed | Allowed Values                                          | Meaning                                                                                                                |
| --------- | -------- | -------------------- | ------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| **Name**  | ✔️     | ✔️                 | A valid attribute name from the IFC schema.             | The attribute must exist and have a non-empty value.                                                                   |
| **Value** | ❌       | ✔️                 | Any value appropriate to the data type of the attribute | The value of the attribute must match, see [DataType documentation](DataTypes.md#xml-base-types) for more information. |

## Examples

| Applicability Intention                                                                               | Requirement Intention                                                                                          | Facet Definition                                            |
| ----------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------- |
| Any entity with a Name of "ABC123"                                                                    | The entity (e.g. Project) must be named "ABC123"                                                               | Name="Name", Value="ABC123"                                 |
| Any entity (but typically IfcMapConversion) with an Easting of 312345                                 | The entity (e.g. IfcMapConversion) must be geolocated such that the origin is at the Easting of 312345         | Name="Easting", Value="312345"                              |
| Any entity with a name starting with "WT" followed by 2 digits, such as WT01, WT02, etc.              | The element must have the naming scheme of WT01, WT02, etc                                                     | Name="Name", value="WT[0-9]{2}"                             |
| Any entity with a non-empty Description                                                               | The entity must have a description                                                                             | Name="Description"                                          |
| Any entity (typically an IfcTask) with a Status set to either "NOTSTARTED", "STARTED", or "COMPLETED" | The entity Status (e.g. for an IfcTask) must be filled out with either "NOTSTARTED", "STARTED", or "COMPLETED" | Name="Status", Value=["NOTSTARTED", "STARTED", "COMPLETED"] |
| Any entity (typically an IfcTaskTime) with a DurationType set to WORKTIME (i.e. based on a calendar)  | The duration type (e.g. for an IfcTaskTime) must be based on a calendar, not elapsed time                      | Name="DurationType", Value="WORKTIME"                       |
