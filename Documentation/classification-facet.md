# Classification facet

A **Classification System** is a defined hierarchy to categorise elements. An example popular **System** is "Uniclass 2015". Within a **System**, there is a hierarchy of short **Reference** codes that categorise elements in increasing levels of specificity, such as "EF_25_10" and "EF_25_10_25". Any object in IFC model can have a **Classification Reference**.

The **Classification Facet** is different to the **Entity Facet**. The **Entity Facet** is restricted to built-in IFC classes and predefined types, which may also function as a method of **Classification**. In contrast, a **System** specified in the **Classification Facet** refers to a third party, non-IFC **System**.

IFC models keep track of **Classification** names, dates, versions, and other data to uniquely identify the **System**, and may even store the hierarchy of **References**. For this reason, **Classification** requirements should use the **Classification Facet**, as opposed to the **Property Facet**.

**Classifications** are a great way to identify **Applicable** entities, or **Require** that entities should follow a nominated **Classification** system by a workflow, such as in an asset management system, work breakdown structure, or coordination requirement.

## Parameters

Parameter | Required | Restrictions Allowed | Allowed Values | Meaning
--- | --- | --- | --- | ---
**System** | ❌ | ✔️ | The name of the **Classification System** | The element must be classified with a reference that is part of a classification system with this name
**Value** | ❌ | ✔️ | The value of a **Refeference** code in the **Classification System** | The element must be classified with a **Reference** which has a code that matches this value. The value is typically a short code with a separating character that denotes the level of classification

If no parameters are specified, then it means that any **Classification** should be present, regardless of **System** name or **Reference** code.

## Examples

Applicability Intention | Requirement Intention | Facet Definition
--- | --- | ---
Any classified element | The entity must be classified | No parameters
Any entity classified using OmniClass | The entity must be classified using OmniClass | System="OmniClass"
Any entity classified with either OmniClass or Uniclass 2015 | The entity must be classified using either OmniClass or Uniclass 2015 | System=["OmniClass", "Uniclass 2015"]
Any entity with a classification reference of "EF_25_10_25" | The element (e.g. a wall) must be classified using the reference "EF_25_10_25" | Value="EF_25_10_25"
Any element with a Uniclass 2015 classification reference starting with EF_25_10 | The entity (e.g. a wall) must use Uniclass 2015 and have are reference starting with EF_25_10 | System="Uniclass 2015", Value="EF_25_10.*"
