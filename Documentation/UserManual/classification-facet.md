# Classification facet

A **Classification System** is a defined hierarchy to categorise elements. Some popular classification systems include "Uniclass 2015", "ETIM" and "CCI". Within a **System**, there is a hierarchy of short reference **Codes** that categorise elements in increasing levels of specificity, such as "EF_25_10" and "EF_25_10_25". Any object in IFC model can have a [Classification Reference](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcClassificationReference.htm).

The **Classification Facet** is different to the **Entity Facet**. The **Entity Facet** is restricted to built-in IFC classes and predefined types, which may also function as a method of **Classification**. In contrast, a classification refers to a third party, non-IFC classifications.

IFC models keep track of classification names, dates, versions, and other data to uniquely identify them. For this reason, **Classification** requirements should use the **Classification Facet**, as opposed to the **Property Facet**.

**Classifications** are a great way to identify **Applicable** entities, or **Require** that entities should follow a nominated **Classification** system by a workflow, such as in an asset management system, work breakdown structure, or coordination requirement.

## Parameters

| Parameter  | Required | Restrictions Allowed | Meaning                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| ---------- | -------- | -------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **System** | ✔️     | ✔️                 | The name of the classification system.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| **Value**  | ❌       | ✔️                 | The value of a refeference code within that classification system. It is typically an official name or a short code.                                                                                                                                                                                                                                                                                                                                                                                                                          |
| **URI**    | ❌       | ❌                   | Uniform Resource Identifier of the class. Used to reference a standardized definition of a class, to ensure consistency of interpretation. The target resource should include a name and definition, and preferably comply with the ISO 12006-3 and ISO 23386. This is an optional attribute that is not subject to IDS checking - the IFC model does not need to have the same or any URI. One source of valid URIs is [the bSDD](https://search.bsdd.buildingsmart.org/), and an example URI is that of a "Beam": [https://identifier.buildingsmart.org/uri/buildingsmart/ifc/4.3/class/IfcBeam](https://identifier.buildingsmart.org/uri/buildingsmart/ifc/4.3/class/IfcBeam). |


## Classification facet interpretation

### Applicability

| Classification System | Classification Value | IDS Interpretation                                                                                  |
| --------------------- | -------------------- | --------------------------------------------------------------------------------------------------- |
| ETIM                  | -                    | Applies to all entities classified using the *ETIM* classification system, regardless of the value. |
| ETIM                  | EC000009             | Applies to all entities with a code *EC000009* of classification system *ETIM*.                     |

### Requirements

| IDS Cardinality | Classification System | Classification Value | URI    | Configuration Allowed? | IDS Interpretation                                                                                                                |
| --------------- | --------------------- | -------------------- | --- | ---------------------- | --------------------------------------------------------------------------------------------------------------------------------- |
| REQUIRED        | ETIM                  | -                    | [https://id...](https://identifier.buildingsmart.org/uri/etim/etim/10.0)    | ✅                     | Applicable objects must have the classification system *ETIM* populated (i.e. not null).                                          |
| REQUIRED        | ETIM                  | EC000009             | [https://id...](https://identifier.buildingsmart.org/uri/etim/etim/10.0/class/EC000009)    | ✅                     | The classification *ETIM* must have the value *EC000009* (on applicable objects).                                                 |
| OPTIONAL        | ETIM                  | -                    | [https://id...](https://identifier.buildingsmart.org/uri/etim/etim/10.0)    | ❌                     | Not allowed. Optionality does not make sense - no added field to require.                                                         |
| OPTIONAL        | ETIM                  | EC000009             | [https://id...](https://identifier.buildingsmart.org/uri/etim/etim/10.0/class/EC000009)    | ✅                     | If the classification *ETIM* exists on applicable objects, it needs to have the value *EC000009*.                                 |
| PROHIBITED      | ETIM                  | -                    | [https://id...](https://identifier.buildingsmart.org/uri/etim/etim/10.0)    | ✅                     | The classification *ETIM* must not exist on applicable objects, even if empty.                                                    |
| PROHIBITED      | ETIM                  | EC000009             | [https://id...](https://identifier.buildingsmart.org/uri/etim/etim/10.0/class/EC000009)    | ✅                     | The classification *ETIM* must not have the value *EC000009* (on applicable objects). Null is also an allowed value in this case. |
