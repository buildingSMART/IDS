# Valid PartOf Containers

The use of PartOf in different schema versions shoud be compatible with the relevant classes as follows.

## Groups inheritance tree

The following classes are used to defined grouping via `IfcRelAssignsToGroup`.

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

## Other forms 

It is also possible to define elements belonging to an `IfcElementAssembly` via `IfcRelAggregates`.

## Enumeration

The entire alphabetical list of valid strings is:

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
