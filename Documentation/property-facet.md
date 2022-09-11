# Property facet

IFC comes with a way to define custom metadata attached to objects called **Properties**. **Properties** have a **Name** (such as "FireRating"), a **Value** provided by a user (such as "180/180/180" in Australia), and similar **Properties** are grouped into **Property Sets**.

Some of these **Property Sets** and **Properties** are defined by buildingSMART to help standardise common properties that are common to projects around the world. For example, the "FireRating" **Property** that is part of the "PSet\_WallCommon" **Property Set** is defined by buildingSMART. Users can also define their own **Properties** and **Property Sets**, which may be unique to the project, or distributed using the **Property Set** templates feature of IFC. Naturally, it is encouraged to specify **Properties** that are standardised by buildingSMART before inventing custom ones. All standardised **Properties** will be part of a **Property Set** with a name prefixed with either "Pset_" or "Qto_".

**Properties** are applicable to different entities. For example, some properties such as **LoadBearing** can be applied to walls, columns, and beams, but not furniture, ducts, or cables. This is known as the **Applicable Entity**. When specifying **Properties** in an IDS, it is important to consider which objects they can apply to. All sorts of objects can have **Properties** applied, not only physical objects like doors, windows, and slabs, but also non-physical objects like tasks, materials, structural profile cross sections, or labour resources.

A special type of **Property** is known as a **Quantity**. Whereas **Properties** refer to any arbitrary information about an object, **Quantities** refer specifically to calculated dimensions of the object, such as length, width, height, surface area, or net volume. IFC makes a distinction between **Properties** and **Quantities**, but in IDS they are interchangable, and you are allowed to specify **Quantities** just the same as a **Property** with this facet. Just like **Properties**, **Quantities** are grouped into **Quantity Sets** and have a **Value**.

To see what **Properties** are standardised by buildingSMART, check the following lists below. You will see a list of **Property Sets**. Clicking on a **Property Set** will bring you to its page, which will show the **Applicable Entity** just below the page title, as well as a table of **Property Names** and expected data types for the **Values**, and have an **Applicable Entity**.

 - [IFC4X3 Property Sets](http://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/annex-b3.html)
 - [IFC4 Property Sets](https://standards.buildingsmart.org/IFC/RELEASE/IFC4/ADD2_TC1/HTML/link/alphabeticalorder-property-sets.htm)
 - [IFC4 Quantity Sets](https://standards.buildingsmart.org/IFC/RELEASE/IFC4/ADD2_TC1/HTML/link/alphabeticalorder-quantity-sets.htm)
 - [IFC2X3 Property Sets](https://standards.buildingsmart.org/IFC/RELEASE/IFC2x3/TC1/HTML/psd/psd_index.htm)

To see what **Quantities** are available for an IFC class, you will need to check the IFC documentation. Here is how you might find a list of valid **Quantities** for the IFC4X3 schema. Note that IFC2X3 only has properties, not quantities.

 1. Browse to the documentation page for the IFC class you are specifying. For example, [this is the IfcWall documentation page](http://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcWall.htm).
 2. Scroll down to the **Property Sets** section of the documentation. If you are viewing the IFC4 documentation, you will also need to scroll down to the **Quantity Sets** section of the documentation.
 4. Click on any **Property Set** or **Quantity Set** name to see a list of valid **Property Names** you can use, and a description and indication of data type.

Instead of checking the documentation, your IDS authoring software may help you to shortlist valid **Property Sets**.

**Property Values** that are filled out by the user will always have a data type. For example, the **Value** may be a simple text value, a boolean true or false value, or a number. If it is a number, the value may be unitless, such as a count of a value, or have a unit, such as a length, area, or more complex unit like a flow rate, pressure, or voltage range.

IDS currently specifies all unit-based values based on SI units. You can see a full list of which units are specified for which type of value in the [IDS Units Table](units.md).

Specify properties are critical providing supplementary information to objects in a model. It is also important to follow buildingSMART standardised **Properties** where possible to ensure that data is highly structured and can be predictably retrieved. The **Property Facet** is considered to be one of the most commonly used facets in IDS.

## Parameters

Parameter | Required | Restrictions Allowed | Allowed Values | Meaning
--- | --- | --- | --- | ---
**Property Set** | ✔️ | ✔️ | Any custom or buildingSMART standardised property set name. Standardised names must begin with "Pset_" or "Qto_" and can be found in the IFC documentation. | The object has the specified property set.
**Name** | ✔️ | ✔️ | Any text property name. Standardised buildingSMART property names can be found in the buildingSMART documentation. | The property must exist in the specified property set and have a non-empty value.
**Value** | ❌ | ✔️ | Any value appropriate to the data type of the property | The value of the attribute must match exactly. To specify numbers, you must use a dot as the decimal separator, and not use a thousands separator (e.g. `4.2` is valid, but `1.234,5` is invalid). Scientific notation is allowed (e.g. `1e3` to represent `1000`). To specify true or false, you must specify `TRUE` or `FALSE` as uppercase characters.
**Measure** | ❌ | ❌ | A valid type name, taken from the [IDS Units Table](units.md) | The value must use the specified measure type. The units specified in the IDS use the [IDS Units Table](units.md), though the project may use any unit.

## Examples

Applicability Intention | Requirement Intention | Facet Definition
--- | --- | ---
Any wall entity with an acoustic rating | The entity (e.g. wall) must have an acoustic rating |
Property Set="Pset\_WallCommon", Name="AcousticRating"
Any column entity with a fire rating of of "2HR" | The entity (e.g. column) must have a fire rating of "2HR" | Property Set="Pset\_ColumnCommon", Name="FireRating", value="2HR"
Any slab entity with a net volume between 20-100 cubic meters | The entity (e.g. slab) must have a net volume between 20-100 cubic meters | Property Set="Qto\_SlabBaseQuantities", Name="NetVolume", Value="[20<=Value<=100](restrictions.md)"
Any in-situ or precast concrete element | The entity (e.g. slab) must have a casting method set either to in-situ or precast | Property Set="Pset\_ConcreteElementGeneral", Name="CastingMethod", value=["INSITU", "PRECAST"]
Any entity with our custom property called ConcreteMix chosen from A, B, or C stored in our MyCompany\_Concrete property set | The entity must have a custom property called ConcreteMix with a value chosen from A, B, or C stored in a property set named MyCompany\_Concrete | Property Set="MyCompany\_Concrete", Name="ConcreteMix", value=["A", "B", "C"]
