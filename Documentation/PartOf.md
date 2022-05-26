# PartOf facet

The `PartOf` facet is designed to check that an element is defined to be part of a predefined set of aggregators.

The `PartOf.Entity` property identifies the type of the aggregator. 

The predefined aggregation types are:

- `IfcGroup` and its descendant classes, and
- `IfcElementAssembly`

## IfcGroup

When `PartOf.Entity`  is any of the descendant classes of 'IfcGroup', the facet is satisfied when an entity belongs 
to the a group via one or more instances of `IfcRelAssignsToGroup`.

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

## IfcElementAssembly

When `PartOf.Entity` is `IfcElementAssembly`, the facet is satisfied when an entity belongs 
to at least one IfcElementAssembly via instances of `IfcRelAggregates`.

## Enumeration

The entire alphabetical list of valid strings for `PartOf.Entity` is:

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