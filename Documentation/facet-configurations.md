# Facet validity

This working document defines the possible configurations and intents for the various facets and their configurations.

## Entities

IDS Wall - SubType Marco
IDS Wall - SubType USERDEFINED

WALL - PARAPET
WALL - USERDEFINED -> Claudio's Type
WALL - USERDEFINED -> Marco's Type

NAME is mandatory.

| Fields Entered   | Required | Optional | Prohibited | Applicability |
| ---------------- | -------- | -------- | ---------- | ------------- |
| NAME             | ✅       | ❌       | ❌         | ✅            |
| NAME / [SUBTYPE] | ✅       | ❌       | ❌         | ✅            |

Optional Entity requirements have no meaning? An Applicable Element is a IFCDOOR or it is not.

Always express entity in positive terms.
Disallowed IFC types can be expressed prohibiting their applicability.

The logic for the identification of values for SUBTYPE is to return an enumeration of values:

1. If a type is defined via the IfcRelDefinesByType relation
  the PredefinedType of the type overrides the entity's PredefinedType (which should be empty according to IFC documentation)
  1.1 if Type's PredefinedType is .USERDEFINED.
    -> IfcElementType.ElementType
    -> .USERDEFINED.
  1.2 else Type's PredefinedType (if not null)
    -> Type's - PredefinedType
2. the value of the direct attribute PredefinedType
  2.1 if the attribute PredefinedType == .USERDEFINED. then the value of the attribute IfcElement/ObjectType is used
  2.2 else entity's PredefinedType (if not null)
3. TODO document the same for ElementType and ProcessType

TODO: check if the validation service of IFC prevents entity level types to be defined when type's type is specified.

-> Userdefined
-> whatever the value is in the ifc

REQUIRED

Name: Entity name must match with the constraint (enumerations/regex included)
Name and PREDEFINEDTYPE:
  IDS: IFCWALL/.USERDEFINED. -> IFC Wall with PREDEFINEDTYPE = .userdefined. -> Pass
  IDS: IFCWALL/.USERDEFINED. -> IFC Wall with PREDEFINEDTYPE = .userdefined. with ObjectType = "FOO" -> Pass
  IDS: IFCWALL/FOO -> IFC Wall with PREDEFINEDTYPE = .userdefined. with ObjectType = "FOO" -> Pass

APPLICABILITY

Both must match with the constraint (enumerations/regex included)

## Attribute

NAME is mandatory.

| Fields Entered | Required | Optional | Prohibited | Applicability |
| -------------- | -------- | -------- | ---------- | ------------- |
| NAME           | ✅       | ❌       | ✅         | ✅            |
| NAME / [VALUE] | ✅       | ✅       | ✅         | ✅            |

### Interpretation

REQUIRED

NAME: The Attribute should be populated (i.e. not null) (this is different from the Property facets, which accepts a null)
NAME/VALUE: all matching attributes must match the value constraints (excludes null)

PROHIBITED

- NAME: The Attribute should not be populated
- NAME / [VALUE]: all matching attributes cannot match the value constraints (null is valid!)
  - Name = Red IFC: NULL -> pass
  - Name = Red IFC: green -> pass
  - Name = Red IFC: red -> fail

OPTIONAL

NAME / [VALUE]: the attribute value could either be null or match the constraint

APPLICABILITY

- NAME: Any entity where the Attribute is not null
- NAME/VALUE: entity where the Attribute and the value constraint is satisfied (null is not evaluated)

## Properties

PSET and NAME are mandatory.

| Fields Entered                     | Required | Optional | Prohibited | Applicability |
| ---------------------------------- | -------- | -------- | ---------- | ------------- |
| PSET / NAME                        | ✅       | ❌       | ✅         | ✅            |
| PSET / NAME / [DATATYPE]           | ✅       | ✅       | ❌         | ✅            |
| PSET / NAME / [DATATYPE] / [VALUE] | ✅       | ✅       | ❌         | ✅            |
| PSET / NAME / [VALUE]              | ❌       | ❌       | ❌         | ❌            |

⚠️TODO: should we discuss the case of multiple PSET / NAME matches that is possible with patterns?

For an evaluation of the rationale, see [these minutes](https://github.com/buildingSMART/IDS/issues/206#issuecomment-1820696088).

⚠️TODO: is IFCLABEL($) valid IFC?

### Interpretation

REQUIRED

IDS has PSET/PNAME : A pset/pname has to exist (null is accepted as a pass, any value of any datatype is accepted)
IDS HAS PSET/PNAME/DATATYPE: A pset pname has to exist. The IFC value has to be of the required IDS datatype (check Empty values against validation) - Null values should be failing
IDS HAS PSET/PNAME/DATATYPE/VALUE: Like the previous, PLUS: the IFC value needs to comply with the IDS restriction

OPTIONAL

IDS has: PSET/PNAME : This is useless -> Prohibited by the tool
IDS HAS PSET/PNAME/DATATYPE: We might not have the property at all -> pass. If we have the property: the value has got to be non null and of correct data type
IDS HAS PSET/PNAME/DATATYPE/VALUE: We might not have the property at all -> pass. If we have the property: the value has got to be non null and of correct data type. The IFC value must comply with the IDS VALUE restriction

PROHIBITED

IDS has: PSET/PNAME: We cannot have the pset/pname combination in the IFC file, regardless of any value
IDS HAS PSET/PNAME/DATATYPE: This does not sound like a valid use case -> Prohibited by the tool
IDS HAS PSET/PNAME/DATATYPE/VALUE: This does not sound like a valid use case -> Prohibited by the tool (there are ways to limit the values accepted in the positive by the REQUIRED/OPTIONAL branches)

APPLICABILITY

IDS has: PSET/PNAME : A pset/pname exists (null is accepted as a pass, any value of any datatype is accepted)
IDS HAS PSET/PNAME/DATATYPE: A pset pname exists. The IFC value type has to match the required IDS datatype (null values fail)
IDS HAS PSET/PNAME/DATATYPE/VALUE: Like the previous, PLUS: the IFC value needs to comply with the IDS restriction

## Classification

We want to change the specs so that SYSTEM is mandatory (schema change!!!)

| Fields Entered   | Required | Optional | Prohibited | Applicability | Notes                                                |
| ---------------- | -------- | -------- | ---------- | ------------- | ---------------------------------------------------- |
|                  | ❌       | ❌       | ❌         | ❌            | prohibited in schema, audit to exclude empty strings |
| [VALUE]          | ❌       | ❌       | ❌         | ❌            | prohibited in schema, audit to exclude empty strings |
| SYSTEM           | ✅       | ❌       | ✅         | ✅            |                                                      |
| SYSTEM / [VALUE] | ✅       | ✅       | ✅         | ✅            |                                                      |

Optional = If the applicable element has classifications at least one should match the value/system.

REQUIRED

- SYSTEM: ANY IFC VALUE -> Pass
  - entity -> at least one classifications for the entity being tested must match system and its value must be not null
- SYSTEM/VALUE
  - SYSTEM AND VALUE match: at least one classification entry in the ifc file, matches both system and value
    entity -> at least one classifications for the entity being tested must match system and value

OPTIONAL

- SYSTEM: this can never fail, we should never have a requirement that cannot fail, so the solution is to provide a broad inclusive value instead (e.g. regex)
- SYSTEM/VALUE:
  - entity -> if a classifications system exists for the entity being tested its value must match
    - Todo: null would be acceptable

PROHIBITED

- SYSTEM: no specification of the entity can match the system
- SYSTEM/VALUE
  - UNICLASS/EF_25_10: UNICLASS/EF_25_10 -> fail
  - UNICLASS/EF_25_10: OMNICLASS/EF_25_10 -> pass
  - UNICLASS/EF_25_10: UNICLASS/EF_25_30_25 -> pass
  - UNICLASS/EF_25_10: OMNICLASS/EF_25_30_25 -> pass

APPLICABILITY

- SYSTEM: ANY IFC VALUE -> Pass
  - entity -> at least one classifications for the entity being tested must match system and its value must be not null
- SYSTEM/VALUE
  - SYSTEM AND VALUE match: at least one classification entry in the ifc file, matches both system and value
    entity -> at least one classifications for the entity being tested must match system and value

## Material

- in the requirements we have to allow multiple materials to enable prohibited/optional (already possible)
- in the applicability we have to allow multiple materials to target elements with multiple materials in AND (already possible)

| Fields Entered | Required | Optional | Prohibited | Applicability |
| -------------- | -------- | -------- | ---------- | ------------- |
|                | ✅       | ❌       | ✅         | ✅            |
| [VALUE]        | ✅       | ✅       | ✅         | ✅            |

Optional is intended to help provide a closed list of values (useful for bim authors)

https://github.com/buildingSMART/IDS/issues/92

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
The relevant issue is https://github.com/buildingSMART/IDS/issues/198

## PartOf

Should relation become a list? NO! Keep as an attribute with one value, because we can distinguish (e.g. sensor/door) filtering by type.
We encourage a smart use of type filtering to avoid false positives and negatives (⚠️TODO: document this meaningfully)

| Fields Entered      | Required | Optional | Prohibited | Applicability |
| ------------------- | -------- | -------- | ---------- | ------------- |
| ENTITY              | ✅       | ❌       | ✅         | ✅            |
| ENTITY / [RELATION] | ✅       | ❌       | ✅         | ✅            |

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

# Questions

## restriction clone

Spinning our own `xs:restriction` alternative, would remove some issues with basetype and embedded xml entities

A special case of the restriction for values would give us the opportunity to explicitly allow/disallow a few scenarios, such as

- Null
  - Must be null
  - Cannot be null
  - Null is accepted as one of the possible values
- N/A as not applicable?
- N/A as not available?

With these logical cases handled explicitly in the in check perhaps scenarios become more straightforward.

However this needs to be evaluated carefully for both the applicability and requirements cases.
