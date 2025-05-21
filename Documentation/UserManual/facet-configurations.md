## Entities

### Required fields

`name` is mandatory.
`predefinedType` is optional.

### Entity facet interpretation

| IDS Cardinality | Entity Name | Entity Predefined Type | Configuration Allowed? | IDS Interpretation                                                                                         |
| --------------- | ----------- | ---------------------- | ------- | ---------------------------------------------------------------------------------------------------------- |
| REQUIRED        | IFCEXAMPLE  | -                      | ✅      | Applicable objects must be of entity IFCEXAMPLE.                                                           |
| REQUIRED        | IFCEXAMPLE  | EXAMPLE                | ✅      | Applicable objects must be of entity IFCEXAMPLE and predefined type EXAMPLE.                               |
| OPTIONAL        | IFCEXAMPLE  |                        | ❌      | Optionality does not make sense - no added field to require.                                               |
| OPTIONAL        | IFCEXAMPLE  | EXAMPLE                | ✅      | If applicable object is an IFCEXAMPLE entity, it must also have the EXAMPLE predefined type.               |
| PROHIBITED      | IFCEXAMPLE  |                        | ✅      | Applicable objects can not be of IFCEXAMPLE entity.                                                        |
| PROHIBITED      | IFCEXAMPLE  | EXAMPLE                | ✅      | Applicable objects can be of IFCEXAMPLE entity (or else), but not if it is of the EXAMPLE predefined type. |

### IFC Predefined Types

The logic for the identification of `predefinedType` in an IFC file:

----**IF:** [the object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcObject.htm) is defined by [a type](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcTypeObject.htm) (look for [IfcRelDefinesByType](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcRelDefinesByType.htm) relation)

-------- **IF:** the [type object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcTypeObject.htm) has a `PredefinedType` with a value `USERDEFINED`

------------ The value of the predefined type is in the `ElementType` attribute of that [type object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcTypeObject.htm). ⬅️

-------- **ELSE IF:** the [type object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcTypeObject.htm) has a `PredefinedType` with a value other than `USERDEFINED`

------------ The value of the predefined type is in the `PredefinedType` attribute of that [type object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcTypeObject.htm). ⬅️

-------- **ELSE:** the [type object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcTypeObject.htm) does not define the predefined type - look in the object instance. ⬇️

---- **ELSE:**

-------- **IF:** [the object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcObject.htm) has a `PredefinedType` with a value `USERDEFINED`.

------------ The value of the predefined type is in the `ObjectType` attribute of that [object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcObject.htm). ⬅️

--------**ELSE IF:** [the object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcObject.htm) has a `PredefinedType` with a value other than `USERDEFINED`

------------ The value of the predefined type is in the `PredefinedType` attribute of that [object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcObject.htm). ⬅️

-------- **ELSE:** the [object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcObject.htm) does not have a predefined type. 🔚

**Examples:**

| IDS Entity | IDS Predefined Type | IFC Entity | IFC Predefined Type | IFC Element/Object Type | IFCxIDS Result |
| ---------- | ------------------- | ---------- | ------------------- | ----------------------- | -------------- |
| IFCWALL    | USERDEFINED         | IFCWALL    | USERDEFINED         | -                       | ✅             |
| IFCWALL    | USERDEFINED         | IFCWALL    | USERDEFINED         | FOO                     | ✅             |
| IFCWALL    | FOO                 | IFCWALL    | USERDEFINED         | FOO                     | ✅             |
| IFCWALL    | FOO                 | IFCWALL    | FOO                 | -                       | ✅             |

## Attribute

### Required fields

`name` is mandatory. `value` is optional.

### Attribute facet interpretation

| IDS Cardinality | Attribute Name | Attribute Value | Configuration Allowed? | IDS Interpretation                                                                                                            |
| --------------- | -------------- | --------------- | ---------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| REQUIRED        | Example        | -               | ✅                     | Applicable objects must have the attribute *Example* populated (i.e. not null).                                               |
| REQUIRED        | Example        | Answer          | ✅                     | The attribute *Example* must have the value *Answer* (on applicable objects).                                                 |
| OPTIONAL        | Example        | Answer          | ✅                     | If the attribute *Example* exists on applicable objects, it needs to have the value *Answer*.                                 |
| OPTIONAL        | Example        | -               | ❌                     | Optionality does not make sense - no added field to require.                                                                  |
| PROHIBITED      | Example        | -               | ✅                     | The attribute *Example* must not exist on applicable objects, even if empty.                                                  |
| PROHIBITED      | Example        | Answer          | ✅                     | The attribute *Example* must not have the value *Answer* (on applicable objects). Null is also an allowed value in this case. |

## Properties

### Required fields

Both `propertySet` and `baseName` are mandatory. Both `dataType*` and `value` are optional, but if `value` is provided, it requires also `dataType*`. Optional attribute `uri` is only a metadata, not subject to IDS checking.

### Property facet interpretation

| IDS Cardinality | Property Set | Base Name | Data Type | Value | Configuration Allowed? | IDS Interpretation                                                                                                                    |
| --------------- | ------------ | --------- | --------- | ----- | ---------------------- | ------------------------------------------------------------------------------------------------------------------------------------- |
| REQUIRED        | My_Set       | My_Prop   | -         | -     | ✅                     | Applicable objects need to have the property *My_Prop* in the *My_Set*.                                                               |
| REQUIRED        | My_Set       | My_Prop   | IFCTEXT   | -     | ✅                     | (as above) + of data type *IFCTEXT*.                                                                                                  |
| REQUIRED        | My_Set       | My_Prop   | IFCTEXT   | Test  | ✅                     | (as above) + of value *Test*.                                                                                                         |
| REQUIRED        | My_Set       | My_Prop   | -         | Test  | ❌                     | Not allowed. If value is specified, it requires specification of a data type.                                                         |
| OPTIONAL        | My_Set       | My_Prop   | -         | -     | ❌                     | Optionality does not make sense - no added field to require.                                                                          |
| OPTIONAL        | My_Set       | My_Prop   | IFCTEXT   | -     | ✅                     | If applicable object have the property *My_Prop* in *My_Set* set, it needs to be an *IFCTEXT* data type. Lack of property is allowed. |
| OPTIONAL        | My_Set       | My_Prop   | IFCTEXT   | Test  | ✅                     | (as above) + have the value equal *Test*. Lack of property is allowed.                                                                |
| OPTIONAL        | My_Set       | My_Prop   | -         | Test  | ❌                     | Not allowed. If value is specified, it requires specification of a data type.                                                         |
| PROHIBITED      | My_Set       | My_Prop   | -         | -     | ✅                     | The property *My_Prop* must not exist, regardless of the value, even if empty.                                                        |
| PROHIBITED      | My_Set       | My_Prop   | IFCTEXT   | -     | ❌                     | Not allowed. Either prohibit whole property or specify values with REQUIRED/OPTIONAL.                                                 |
| PROHIBITED      | My_Set       | My_Prop   | IFCTEXT   | Test  | ❌                     | Not allowed. Either prohibit whole property or specify values with REQUIRED/OPTIONAL.                                                 |
| PROHIBITED      | My_Set       | My_Prop   | -         | Test  | ❌                     | Not allowed. If value is specified, it requires specification of a data type.                                                         |

<!-- For an evaluation of the rationale, see [these minutes](https://github.com/buildingSMART/IDS/issues/206#issuecomment-1820696088). -->

## Classification

The `system` field is mandatory.
Optional attribute `uri` is only a metadata, not subject to IDS checking.

| Fields Entered   | Required | Optional | Prohibited | Applicability | Notes |
| ---------------- | -------- | -------- | ---------- | ------------- | ----- |
| `system`         | ✅       | ❌       | ✅         | ✅            |       |
| `system`,`value` | ✅       | ✅       | ✅         | ✅            |       |

Optional = If the applicable element has classifications at least one should match the value/system.

REQUIRED

- `system`: ANY IFC VALUE -> Pass
  - entity -> at least one classifications for the entity being tested must match system and its value must be not null
- `system`/`value`
  - `system` AND `value` match: at least one classification entry in the ifc file, matches both system and value
    entity -> at least one classifications for the entity being tested must match system and value

OPTIONAL

- `system`: this can never fail, we should never have a requirement that cannot fail, so the solution is to provide a broad inclusive value instead (e.g. regex)
- `system`/`value`:
  - entity -> if a classifications system exists for the entity being tested its value must match
    - Todo: null would be acceptable

PROHIBITED

- `system`: no specification of the entity can match the system
- `system`/`value`
  - UNICLASS/EF_25_10: UNICLASS/EF_25_10 -> fail
  - UNICLASS/EF_25_10: OMNICLASS/EF_25_10 -> pass
  - UNICLASS/EF_25_10: UNICLASS/EF_25_30_25 -> pass
  - UNICLASS/EF_25_10: OMNICLASS/EF_25_30_25 -> pass

APPLICABILITY

- `system`: ANY IFC VALUE -> Pass
  - entity -> at least one classifications for the entity being tested must match system and its value must be not null
- `system`/`value`
  - `system` AND `value` match: at least one classification entry in the ifc file, matches both system and value
    entity -> at least one classifications for the entity being tested must match system and value




## Material

Optional attribute `uri` is only a metadata, not subject to IDS checking.

- in the requirements we have to allow multiple materials to enable prohibited/optional (already possible)
- in the applicability we have to allow multiple materials to target elements with multiple materials in AND (already possible)

| Fields Entered | Required | Optional | Prohibited | Applicability |
| -------------- | -------- | -------- | ---------- | ------------- |
|                | ✅       | ❌       | ✅         | ✅            |
| `value`        | ✅       | ✅       | ✅         | ✅            |

Optional is intended to help provide a closed list of values (useful for bim authors).

Optional = If the applicable element has materials at least one should match the value

REQUIRED

- No value: at least one material association of any value, not null, must be found
- value: at least one material association, matching the IDS value constraint must be found (null is not allowed)
  - Value will look at all the names of the various forms of material definition that are associated with an element:
    e.g. MaterialLayerSet -> Name + all the associated material names

OPTIONAL

- No value: it can never fail, therefore it's not allowed in the IDS (audit tool will flag as error)
- Value: If any materials exist then at least one material should match the value constraint

PROHIBITED

- No value: no material can be associated with the entity
- Value: no material can match the value (a material can have null value)
  - IDS: Wood, No IFC materials -> pass
  - IDS: Wood, IFC = null name -> pass
  - IDS: Wood, IFC Stone -> Pass
  - IDS: Wood, IFC Wood -> Fail

APPLICABILITY

- No value: at least one material association of any value, not null, was found for the entity
- value: at least one material association, matching the IDS value constraint was found (excluding null)
  - Value will look at all the names of the various forms of material definition that are associated with an element:
    e.g. MaterialLayerSet -> Name + all the associated material names

### Implementation

⚠️TODO: in the documentation we will be explicit that traversing IfcRelDecomposition for the purpose of material evaluation will not be implemented in 1.0.

We need to define what is the behaviour when it comes to the IfcRelDecomposition and the propagation of materials.
The relevant conversation issue is [#198](https://github.com/buildingSMART/IDS/issues/198)

## PartOf

| Fields Entered        | Required | Optional | Prohibited | Applicability |
| --------------------- | -------- | -------- | ---------- | ------------- |
| `entity`              | ✅       | ❌       | ✅         | ✅            |
| `entity`, `relation*` | ✅       | ❌       | ✅         | ✅            |

REQUIRED:

- Entity: A relation is needed to the type of entity required (traversing all valid relationships)
- Entity/Relation: A relation is needed to the type of entity required (traversing only the defined relationship type)

OPTIONAL:

- IDS Entity: IfcWall: If the element has a matching relationship the target should match the Entity.
  - IFC ENtity has a relation, it must be to a wall (but the relation is optional)
  - IFC Opening in a slab -> fail (no relation to the of the entity encounters a wall)
  - Ifc opening in a wall -> pass

PROHIBITED:

- Entity: A relation cannot exist with needed to the type of entity required (traversing all valid relationships)
- Entity/Relation: A relation cannot exist to the type of entity required (traversing only the defined relationship type)

APPLICABILITY:

- Entity: A relation exists to the type of entity required (traversing all valid relationships)
- Entity/Relation: A relation exists to the type of entity required (traversing only the defined relationship type)

___
\* the field is an XML attribute