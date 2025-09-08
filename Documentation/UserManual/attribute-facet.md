# Attribute facet

Every entity in an IFC model has a list of standardised **Attributes**. **Attributes** are a limited set of fundamental data (usually less than 10) associated with all IFC entities. These are fixed by the IFC standard and cannot be customised.

Here are some common attributes and what they mean:

- **GlobalId**: A unique identifier for the element
- **Name**: a short name or label to identify the object for a human. If you had to annotate the object on a drawing or a schedule, the *Name* is often used. For example, a pump *Name* might be P-10-A.
- **Description**: "provided for exchanging informative comments". Typically a longer form of the name, written to be descriptive and readable for humans. For example, a pump *Description* might be *Water Suction Pump*.
- **Tag**: "identifier at the particular instance of a product, e.g. the serial number, or the position number. It is the identifier at the occurrence level.". Usually a short code or number, that may link it back to another BIM application or product specification.

Information that is not critical to the definition of the IFC entity is stored as a **Property**, not an **Attribute**. For more information view the documentation on the [**Property Facet**](property-facet.md).

For this reason, **Attributes** are a good way to specify an **Applicability** to specific elements, or specify a **Requirement** that certain elements shall be identified, named, or described in a particular way.

To see what **Attributes** are available for an IFC class and what their potential values may be, you will need to check the IFC documentation. Here is how you might find a list of valid **Attributes** for the IFC4X3_ADD2 schema. The instructions will be similar for all IFC versions.

 1. Browse to the documentation page for the IFC class you are specifying. For example, [this is the IfcWall documentation page](http://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcWall.htm).
 2. Scroll down to the **Attributes** section of the documentation. Note that by default, not all attributes are shown. Press "_Click to show hidden inherited attributes_" to show all attributes. For IFC4, click on the "_Attribute inheritance_" text header to toggle a table for all attributes.
 3. The **Attributes** table will show the **Name** of each **Attribute**. Note that **Attributes** which do not have a number next to them and are in italics are not allowed to be specified. Only enumerated **Attributes** may be specified. For example, you may specify the **Name** attribute for an IfcWall, but you may not specify **ConnectedTo**.

Instead of checking the documentation, your IDS authoring software may help you to shortlist valid **Attributes**.

## Parameters

| Parameter | Required | Restrictions Allowed | Meaning                                                                                                                                                        |
| --------- | -------- | -------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Name**  | ✔️     | ✔️                 | A valid attribute name from the IFC schema.                                                                                                                           |
| **Value** | ❌       | ✔️                 | Any value appropriate to the data type of the attribute. See [DataType documentation](../ImplementersDocumentation/DataTypes.md#xml-base-types) for more information. |

## Attribute facet interpretation

### Applicability

| Attribute Name | Attribute Value | IDS Interpretation                                                              |
| -------------- | --------------- | ------------------------------------------------------------------------------- |
| Description    | -               | Applies to all entities having a *Description* filled in (not Null or missing). |
| Description    | Answer          | Applies to all entities in which *Description* has a value *Answer*.            |

### Requirements

| IDS Cardinality | Attribute Name | Attribute Value | Configuration Allowed? | IDS Interpretation                                                                                                            |
| --------------- | -------------- | --------------- | ---------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| REQUIRED        | Description        | -               | ✅                     | Applicable objects must have the attribute *Description* populated (i.e. not null).                                               |
| REQUIRED        | Description        | Answer          | ✅                     | The attribute *Description* must have the value *Answer* (on applicable objects).                                                 |
| OPTIONAL        | Description        | -               | ❌                     | Optionality does not make sense - no added field to require.                                                                  |
| OPTIONAL        | Description        | Answer          | ✅                     | If the attribute *Description* exists on applicable objects, it needs to have the value *Answer*.                                 |
| PROHIBITED      | Description        | -               | ✅                     | The attribute *Description* must not exist on applicable objects, even if empty.                                                  |
| PROHIBITED      | Description        | Answer          | ✅                     | The attribute *Example* must not have the value *Answer* (on applicable objects). Null is also an allowed value in this case. |
