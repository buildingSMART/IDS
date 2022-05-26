# PartOf facet

The `PartOf` facet is designed to check that an element is part of a predefined set of aggregators through the appropriate relationship.

The `PartOf.Entity` property identifies the type of the aggregator, and predefined aggregation types are:

- `IfcGroup` (including derived classes), or
- `IfcElementAssembly`

## IfcGroup

When `PartOf.Entity`  is any of the derived classes of `IfcGroup`, the facet is satisfied when an entity 
belongs to a group via one or more instances of `IfcRelAssignsToGroup`.

The value of `PartOf.Entity` should depend on the schema version, as follows: 

| IFC2x3                        | IFC4                            | IFC4x3                           |
| ----------------------------- | ------------------------------- | -------------------------------- |
| IfcGroup                      | IfcGroup                        | IfcGroup                         |
| ~ IfcAsset                    | ~ IfcAsset                      | ~ IfcAsset                       |
| ~ IfcCondition                |                                 |                                  |
| ~ IfcInventory                | ~ IfcInventory                  | ~ IfcInventory                   |
| ~ IfcStructuralLoadGroup      | ~ IfcStructuralLoadGroup        | ~ IfcStructuralLoadGroup         |
|                               | ~~ IfcStructuralLoadCase        | ~~ IfcStructuralLoadCase         |
| ~ IfcStructuralResultGroup    | ~ IfcStructuralResultGroup      | ~ IfcStructuralResultGroup       |
| ~ IfcSystem                   | ~ IfcSystem                     | ~ IfcSystem                      |
|                               | ~~ IfcBuildingSystem            | ~~ IfcBuildingSystem             |
|                               |                                 | ~~ IfcBuiltSystem                |
|                               | ~~ IfcDistributionSystem        | ~~ IfcDistributionSystem         |
|                               | ~~~ IfcDistributionCircuit      | ~~~ IfcDistributionCircuit       |
| ~~ IfcElectricalCircuit       |                                 |                                  |
| ~~ IfcStructuralAnalysisModel | ~~ IfcStructuralAnalysisModel   | ~~ IfcStructuralAnalysisModel    |
| ~ IfcZone                     | ~~ IfcZone                      | ~~ IfcZone                       |

The clause implementation should consider inheritance (e.g. being part of a `IfcBuildingSystem` satisfies a request 
to be part of its superclass `IfcSystem`).

## IfcElementAssembly

When `PartOf.Entity` is `IfcElementAssembly`, the facet is satisfied when an entity belongs 
to at least one IfcElementAssembly via instances of `IfcRelAggregates`.

## Enumeration

The entire alphabetical list of valid values for the `Entity` property is:

```
IfcAsset
IfcBuildingSystem
IfcBuiltSystem
IfcCondition
IfcDistributionCircuit
IfcDistributionSystem
IfcElectricalCircuit
IfcElementAssembly
IfcGroup
IfcInventory
IfcStructuralAnalysisModel
IfcStructuralLoadCase
IfcStructuralLoadGroup
IfcStructuralResultGroup
IfcSystem
IfcZone
```
