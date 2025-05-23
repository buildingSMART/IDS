# Material facet

Elements like walls, doors, windows, etc. in IFC may have a **Material** associated with them. In the simplest case, an element may have a single **Material**. For example, a chair may be made from a "wood" material. The **Material Facet** lets you filter, require or prohibit elements having this **Material**.

Many disciplines, such as costing, scheduling, sustainability and structural analysis depend on correct **Material** association and exact spelling.

## Parameters

| Parameter | Required | Restrictions Allowed | Meaning                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| --------- | -------- | -------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Value** | ❌       | ✔️                 | Any material name or category. The material name is typically specific to the project or local convention. The element must be made out of a **Material** with the specified name or category. If there are multiple **Materials**, then any **Material**, **Layer**, **Profile** or **Constituent** with that name or category will also satisfy the requirement.                                                                                                                                                                                                                                                                                                                                                                                       |
| **URI**   | ❌       | ❌                   | Uniform Resource Identifier of the material. Used to reference a standardized definition of a material, to ensure consistency of interpretation. The target resource should include a name and definition, and preferably comply with the ISO 12006-3 and ISO 23386. This is an optional attribute that is not subject to IDS checking - the IFC model does not need to have the same or any URI. One source of valid URIs is [the bSDD](https://search.bsdd.buildingsmart.org/), and an example URI is that of a "Plywood": [https://identifier.buildingsmart.org/uri/cei-bois.org/wood/1.0.0/class/8dca70a2-01a2-489b-9381-fbeff09db8dc](https://identifier.buildingsmart.org/uri/cei-bois.org/wood/1.0.0/class/8dca70a2-01a2-489b-9381-fbeff09db8dc). |
|           |          |                      |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |

\* The material Category is an optional attribute of [IfcMaterial](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcMaterial.htm), and is recommended by the IFC to be one of 'concrete', 'steel', 'aluminium', 'block', 'brick', 'stone', 'wood', 'glass', 'gypsum', 'plastic', or 'earth'.

The `value` field is optional. Optional attribute `uri` is only a metadata, not subject to IDS checking.

If no parameters are specified, then it means that any **Material** should be present, regardless of name or category.

## IFC Material Relations

An element may have multiple **Materials** associated in three possible scenarios:

- **Layered materials**: an element (e.g. a wall or slab) is parametrically defined in terms of material layers with a thickness (e.g. stud layer, insulation layer, and gypsum layer). Each layer may have a different **Material**.
- **Profiled materials**: an element (e.g. a column or beam) is parametrically defined in terms of a profile (e.g. C-profile, Z-profile, or I-profile) extruded along a path. Composite columns and beams may have multiple profiles from different **Materials**.
- **Constituent materials**: an element (e.g. a window, or slab) where portions of the element are made out of different **Materials** (e.g. the window glazing and the window frame) or mixed  (e.g. a concrete slab may be composed of a percentage of cement, aggregate, etc)

![Material Facet](Graphics/material-facet.png)

In IFC (4x3 and before) materials ([IfcMaterial](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcMaterial.htm)) can be associated to objects ([IfcObject](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcObject.htm)) through [IfcRelAssociatesMaterial](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcRelAssociatesMaterial.htm) relation. 

However, the relation is not always direct. Sometimes objects are defined by a type or are parts aggregated in a larger assembly. Also, there are multiple ways to associate material with an object, for example, through a set of layers or as a list of constituents.

![Material-relation](Graphics/material-relation.svg)

The IDS simplifies the material relation for its users, allowing them to simply specify material association, shifting the interpretation of various possible relations to IFC-IDS checking tools.

<!-- ⚠️TODO: in the documentation we will be explicit that traversing IfcRelDecomposition for the purpose of material evaluation will not be implemented in 1.0. We need to define what is the behaviour when it comes to the IfcRelDecomposition and the propagation of materials. -->


## Material facet interpretation

### Applicability

| Material Value | IDS Interpretation                                                                                                                                            |
| -------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| -              | Applies to all entities with any associated material. Good way to filter only physical objects, given they have a material relation.                          |
| Steel          | Applies to all entities with an associated material named *Steel* (exact spelling and case). It is not relevant if the entity has more material associations. |

### Requirements

| IDS Cardinality | Material Value | Configuration Allowed? | IDS Interpretation                                                                               |
| --------------- | -------------- | ---------------------- | ------------------------------------------------------------------------------------------------ |
| REQUIRED        | -              | ✅                     | Applicable objects must have at least one related material, no matter its name.                  |
| REQUIRED        | Steel          | ✅                     | Applicable objects must have the material *Steel* related. More materials are allowed.           |
| OPTIONAL        | -              | ❌                     | Not allowed. No added value in specifying that it can have material or not.                      |
| OPTIONAL        | Steel          | ✅                     | Applicable objects don't need to have any materials, but if they do, *Steel* must be among them. |
| PROHIBITED      | -              | ✅                     | Applicable objects must not have any materials associated.                                       |
| PROHIBITED      | Steel          | ✅                     | *Steel* must not be among the materials associated with applicable objects.                      |

### Examples of interpering IFC materials

| IDS Material Value | IFC Material.Name           | IFC Material.Category | IFCxIDS Result |
| ------------------ | --------------------------- | --------------------- | -------------- |
| Steel              | Steel                       | -                     | ✅             |
| Steel              | S275                        | -                     | ❌             |
| Steel              | S275                        | Steel                 | ✅             |
| Brick              | [Gypsum, Brick, Insulation] | -                     | ✅             |
