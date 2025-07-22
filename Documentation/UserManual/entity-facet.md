# Entity facet

Every instance in an IFC model has an "IFC Class" (also known as EXPRESS entity). For example, wall instances will have IFC class IfcWall, and door instances will have IFC class IfcDoor. Instances that don't represent individual building elements will also have a class. For example, project has class IfcProject, window types have class of IfcWindowType, and cost items have a class IfcCostItem.

Classes aren’t just for categorising instances. They also indicate what types of properties and relationships it is allowed to have. For example, an instance of IfcWall class can have a fire rating property, but an IfcGrid instance cannot.

One of the most important aspects of writing a specification is to ensure that it applies to the appropriate IFC class. Typically, every single **Specification** will have an **Entity Facet** used in its **Applicability** section.

There are differences in classes between IFC schema versions. More recent IFC schemas contain richer and more diverse IFC classes, which you can compare here:

- [IFC4X3_ADD2 list of IFC class names](http://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/annex-b1.html)
- [IFC4 list of IFC class names](https://standards.buildingsmart.org/IFC/RELEASE/IFC4/ADD2_TC1/HTML/link/alphabeticalorder-entities.htm)
- [IFC2X3 list of IFC class names](https://standards.buildingsmart.org/IFC/RELEASE/IFC2x3/TC1/HTML/alphabeticalorder_entities.htm)

Some classes may also optionally have a **Predefined Type**. This is a further level of categorisation in addition to the IFC Class **Name**. For example, an instance of IfcWall may have a **Predefined Type** of SHEAR, or PARTITIONING. Whereas the IFC Class **Name** is specified by the IFC standard, the **Predefined Type** can be specified by the standard but may also contain custom values defined by the user. Read below about [using the IFC Predefined Types](#ifc-predefined-types).

## Parameters

| Parameter                              | Required | Restrictions Allowed | Meaning                                                                                                |
| -------------------------------------- | -------- | -------------------- | ------------------------------------------------------------------------------------------------------------- |
| **Name** (`name`)                      | ✔️     | ✔️                 | A valid IFC class from the IFC schema. The IFC Class must match exactly. Expressed in UPPERCASE.                                    |
| **Predefined Type** (`predefinedType`) | ❌       | ✔️                 | A valid predefined type from the IFC schema, or any custom text value. The Predefined Type must match exactly. Expressed in UPPERCASE. |

## Entity facet interpretation

### Applicability

| Entity Name | Entity Predefined Type | IDS Interpretation                                      |
| ----------- | ---------------------- | ------------------------------------------------------- |
| IFCWINDOW   | -                      | Applies to all *IfcWindow* entities.                    |
| IFCWINDOW   | SKYLIGHT               | Applies to all *IfcWindow* entities of type *Skylight*. |

### Requirements

| IDS Cardinality | Entity Name | Entity Predefined Type | Configuration Allowed? | IDS Interpretation                                                                                         |
| --------------- | ----------- | ---------------------- | ---------------------- | ---------------------------------------------------------------------------------------------------------- |
| REQUIRED        | IFCWINDOW  | -                      | ✅                     | Applicable objects must be of entity IFCWINDOW.                                                           |
| REQUIRED        | IFCWINDOW  | SKYLIGHT                | ✅                     | Applicable objects must be of entity IFCWINDOW and predefined type SKYLIGHT.                               |
| OPTIONAL        | IFCWINDOW  |                        | ❌                     | Optionality does not make sense - no added field to require.                                               |
| OPTIONAL        | IFCWINDOW  | SKYLIGHT                | ✅                     | If applicable object is an IFCWINDOW entity, it must also have the SKYLIGHT predefined type.               |
| PROHIBITED      | IFCWINDOW  |                        | ✅                     | Applicable objects can not be of IFCWINDOW entity.                                                        |
| PROHIBITED      | IFCWINDOW  | SKYLIGHT                | ✅                     | Applicable objects can be of IFCWINDOW entity (or else), but not if it is of the SKYLIGHT predefined type. |

## IFC Predefined Types

The IFC schema documentation contains a list of standard predefined types. Here is how you might find a list of valid **Predefined Types** for the IFC4X3_ADD2 schema. The instructions will be similar for all IFC versions.

 1. Browse to the documentation page for the IFC class you are specifying. You can get there from the list of IFC class names above. For example, [this is the IfcWall documentation page](http://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcWall.htm).
 2. Scroll down to the **Attributes** section of the documentation and find the **PredefinedType** attribute.
 3. Click on the enumeration link next to the **PredefinedType** attribute to view the list of valid values. For example, for an IfcWall, you will click the link to bring you to [the documentation for IfcWallTypeEnum](http://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcWallTypeEnum.htm).
 4. A list of valid **Predefined Types** are shown in a table.

If **Predefined Types** are needed, choosing from the standard list is highly recommended. However, if they do not apply to your project you may specify any custom value.

### The logic for the identification of `predefinedType` in an IFC file:

----**IF:** [the object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcObject.htm) is defined by [a type](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcTypeObject.htm) (look for [IfcRelDefinesByType](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcRelDefinesByType.htm) relation)

-------- **IF:** the [type object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcTypeObject.htm) has a `PredefinedType` with a value `USERDEFINED`

------------ The value of the predefined type is in the `ElementType` attribute of that [type object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcTypeObject.htm). ✅

-------- **ELSE IF:** the [type object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcTypeObject.htm) has a `PredefinedType` with a value other than `USERDEFINED`

------------ The value of the predefined type is in the `PredefinedType` attribute of that [type object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcTypeObject.htm). ✅

-------- **ELSE:** the [type object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcTypeObject.htm) does not define the predefined type - look in the object instance. ⬇️

---- **ELSE:**

-------- **IF:** [the object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcObject.htm) has a `PredefinedType` with a value `USERDEFINED`.

------------ The value of the predefined type is in the `ObjectType` attribute of that [object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcObject.htm). ✅

--------**ELSE IF:** [the object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcObject.htm) has a `PredefinedType` with a value other than `USERDEFINED`

------------ The value of the predefined type is in the `PredefinedType` attribute of that [object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcObject.htm). ✅

-------- **ELSE:** the [object](https://ifc43-docs.standards.buildingsmart.org/IFC/RELEASE/IFC4x3/HTML/lexical/IfcObject.htm) does not have a predefined type. 🔚

### Examples of interpering IFC Predefined Types

| IDS Entity | IDS Predefined Type | IFC Entity | IFC Predefined Type | IFC Element/Object Type | IFCxIDS Result |
| ---------- | ------------------- | ---------- | ------------------- | ----------------------- | -------------- |
| IFCWALL    | USERDEFINED         | IFCWALL    | USERDEFINED         | -                       | ✅             |
| IFCWALL    | USERDEFINED         | IFCWALL    | USERDEFINED         | FOO                     | ✅             |
| IFCWALL    | FOO                 | IFCWALL    | USERDEFINED         | FOO                     | ✅             |
| IFCWALL    | FOO                 | IFCWALL    | FOO                 | -                       | ✅             |


## Special cases in IFC2X3

Some occurrence entities in IFC2X3 are further specified by their type object.
An example is the definition of an air terminal, which is encoded in IFC2X3 by an occurrence instance of IfcFlowTerminal and a type instance of IfcAirTerminalType.
The entity facet does not have a parameter to further specify the type entity name.
In this case, the IDS follows the convention introduced in IFC4, which also makes the IDS-based check more schema-agnostic.
In the given example, the **name** of the entity to be checked should be IfcAirTerminal (without type) and must be resolved by a given mapping table.
A full list is given in this [table](./Documentation/ImplementersDocumentation/ifc2x3-occurrence-type-mapping-table.md).

## Inheritance

There is no automatic inheritance in IDS entity facet interpretation. In other words, all the entities need to be listed explicitly. This allows for precise and unambiguous specifications.

For example, to create a requirement applicable to all IfcElement objects, one should list all IfcElement sub-entities, such as IfcWall, IfcDoor, etc. Also, the IfcElement should not be listed, as it is an abstract entity - it can't be instantiated, therefore would not appear in a model.

To help users and software implementers specify all commonly used sub-entities of IfcElement, IfcBuiltElement, IfcFlowSegment or else, we provide the table below.

### IfcElement sub-entities in different IFC versions 

|                                                     | IFC4X3 | IFC4 | IFC2X3 |
|-----------------------------------------------------|--------|------|--------|
| IfcElement                                          | ⚠️      | ⚠️    | ⚠️      |
| --- IfcBuildingElement                              |        | ⚠️    | ⚠️      |
| --- IfcBuiltElement                                 | ✅      |      |        |
| ------ IfcBeam                                      | ✅      | ✅    | ✅      |
| --------- IfcBeamStandardCase                       |        | 🚫    |        |
| ------ IfcBearing                                   | ✅      |      |        |
| ------ IfcBuildingElementProxy                      | ✅      | ✅    | ✅      |
| ------ IfcChimney                                   | ✅      | ✅    |        |
| ------ IfcColumn                                    | ✅      | ✅    | ✅      |
| ---------   IfcColumnStandardCase                   |        | 🚫    |        |
| ------ IfcCourse                                    | ✅      |      |        |
| ------ IfcCovering                                  | ✅      | ✅    | ✅      |
| ------ IfcCurtainWall                               | ✅      | ✅    | ✅      |
| ------ IfcDeepFoundation                            | ✅      |      |        |
| --------- IfcCaissonFoundation                      | ✅      |      |        |
| --------- IfcPile                                   | ✅      | ✅    | ✅      |
| ------ IfcDoor                                      | ✅      | ✅    | ✅      |
| --------- IfcDoorStandardCase                       |        | 🚫    |        |
| ------ IfcEarthworksElement                         | ✅      |      |        |
| --------- IfcEarthworksFill                         | ✅      |      |        |
| --------- IfcReinforcedSoil                         | ✅      |      |        |
| ------ IfcFooting                                   | ✅      | ✅    | ✅      |
| ------ IfcKerb                                      | ✅      |      |        |
| ------ IfcMember                                    | ✅      | ✅    | ✅      |
| ---------   IfcMemberStandardCase                   |        | 🚫    |        |
| ------ IfcMooringDevice                             | ✅      |      |        |
| ------ IfcNavigationElement                         | ✅      |      |        |
| ------ IfcPavement                                  | ✅      |      |        |
| ------ IfcPlate                                     | ✅      | ✅    | ✅      |
| --------- IfcPlateStandardCase                      |        | 🚫    |        |
| ------ IfcRail                                      | ✅      |      |        |
| ------ IfcRailing                                   | ✅      | ✅    | ✅      |
| ------ IfcRamp                                      | ✅      | ✅    | ✅      |
| ------ IfcRampFlight                                | ✅      | ✅    | ✅      |
| ------ IfcRoof                                      | ✅      | ✅    | ✅      |
| ------ IfcShadingDevice                             | ✅      | ✅    |        |
| ------ IfcSlab                                      | ✅      | ✅    | ✅      |
| --------- IfcSlabElementedCase                      |        | 🚫    |        |
| --------- IfcSlabStandardCase                       |        | 🚫    |        |
| ------ IfcStair                                     | ✅      | ✅    | ✅      |
| ------ IfcStairFlight                               | ✅      | ✅    | ✅      |
| ------ IfcTrackElement                              | ✅      |      |        |
| ------ IfcWall                                      | ✅      | ✅    | ✅      |
| --------- IfcWallElementedCase                      |        | 🚫    |        |
| --------- IfcWallStandardCase                       | 🚫      | 🚫    |        |
| ------ IfcWindow                                    | ✅      | ✅    | ✅      |
| ---------   IfcWindowStandardCase                   |        | 🚫    |        |
| --- IfcDistributionElement                          | ✅      | ✅    | ✅      |
| ------   IfcDistributionFlowElement                 | ✅      | ✅    | ✅      |
| ---------   IfcEnergyConversionDevice               |        | ✅    | ⚠️      |
| ------------ IfcCoolingTower                        | ✅      | ✅    |        |
| ------------   IfcAirToAirHeatRecovery              |        | ✅    | ✅      |
| ------------ IfcBoiler                              | ✅      | ✅    |        |
| ------------ IfcBurner                              | ✅      | ✅    |        |
| ------------ IfcChiller                             | ✅      | ✅    |        |
| ------------ IfcCoil                                | ✅      | ✅    |        |
| ------------ IfcCondenser                           | ✅      | ✅    |        |
| ------------ IfcCooledBeam                          | ✅      | ✅    |        |
| ------------   IfcElectricGenerator                 | ✅      | ✅    |        |
| ------------ IfcElectricMotor                       | ✅      | ✅    |        |
| ------------ IfcEngine                              | ✅      | ✅    |        |
| ------------   IfcEvaporativeCooler                 |        | ✅    | ✅      |
| ------------ IfcEvaporator                          | ✅      | ✅    |        |
| ------------ IfcHeatExchanger                       | ✅      | ✅    |        |
| ------------ IfcHumidifier                          | ✅      | ✅    |        |
| ------------   IfcMotorConnection                   | ✅      | ✅    |        |
| ------------ IfcSolarDevice                         | ✅      | ✅    |        |
| ------------ IfcTransformer                         | ✅      | ✅    |        |
| ------------ IfcTubeBundle                          | ✅      | ✅    |        |
| ------------   IfcUnitaryEquipment                  |        | ✅    | ✅      |
| ---------   IfcDistributionChamberElement           |        | ✅    | ✅      |
| --------- IfcFlowController                         | ✅      | ⚠️    | ✅      |
| ------------ IfcAirTerminalBox                      | ✅      | ✅    |        |
| ------------ IfcDamper                              | ✅      | ✅    |        |
| ------------   IfcDistributionBoard                 | ✅      |      |        |
| ------------   IfcElectricDistributionBoard         |        | 🚫    | ✅      |
| ------------   IfcElectricTimeControl               |        | ✅    | ✅      |
| ------------ IfcFlowMeter                           | ✅      | ✅    |        |
| ------------   IfcProtectiveDevice                  | ✅      | ✅    |        |
| ------------   IfcSwitchingDevice                   | ✅      | ✅    |        |
| ------------ IfcValve                               | ✅      | ✅    |        |
| --------- IfcFlowFitting                            | ✅      | ⚠️    | ✅      |
| ------------   IfcCableCarrierFitting               |        | ✅    | ✅      |
| ------------ IfcCableFitting                        | ✅      | ✅    |        |
| ------------ IfcDuctFitting                         | ✅      | ✅    |        |
| ------------ IfcJunctionBox                         | ✅      | ✅    |        |
| ------------ IfcPipeFitting                         | ✅      | ✅    |        |
| --------- IfcFlowMovingDevice                       | ✅      | ⚠️    | ✅      |
| ------------ IfcCompressor                          | ✅      | ✅    |        |
| ------------ IfcFan                                 | ✅      | ✅    |        |
| ------------ IfcPump                                | ✅      | ✅    |        |
| --------- IfcFlowSegment                            | ✅      | ⚠️    | ✅      |
| ------------   IfcCableCarrierSegment               |        | ✅    | ✅      |
| ------------ IfcCableSegment                        | ✅      | ✅    |        |
| ------------   IfcConveyorSegment                   |        | ✅    |        |
| ------------ IfcDuctSegment                         | ✅      | ✅    |        |
| ------------ IfcPipeSegment                         | ✅      | ✅    |        |
| --------- IfcFlowStorageDevice                      | ✅      | ⚠️    | ✅      |
| ------------   IfcElectricFlowStorageDevice         |        | ✅    | ✅      |
| ------------ IfcTank                                | ✅      | ✅    |        |
| --------- IfcFlowTerminal                           | ✅      | ⚠️    | ✅      |
| ------------ IfcAirTerminal                         | ✅      | ✅    |        |
| ------------   IfcAudioVisualAppliance              |        | ✅    | ✅      |
| ------------   IfcCommunicationsAppliance           |        | ✅    | ✅      |
| ------------   IfcElectricAppliance                 | ✅      | ✅    |        |
| ------------   IfcFireSuppressionTerminal           |        | ✅    | ✅      |
| ------------ IfcLamp                                | ✅      | ✅    |        |
| ------------ IfcLightFixture                        | ✅      | ✅    |        |
| ------------ IfcLiquidTerminal                      | ✅      |      |        |
| ------------ IfcMedicalDevice                       | ✅      | ✅    |        |
| ------------   IfcMobileTelecommunicationsAppliance |        | ✅    |        |
| ------------ IfcOutlet                              | ✅      | ✅    |        |
| ------------   IfcSanitaryTerminal                  | ✅      | ✅    |        |
| ------------ IfcSignal                              | ✅      |      |        |
| ------------ IfcSpaceHeater                         | ✅      | ✅    |        |
| ------------ IfcStackTerminal                       | ✅      | ✅    |        |
| ------------ IfcWasteTerminal                       | ✅      | ✅    |        |
| ---------   IfcFlowTreatmentDevice                  | ✅      | ⚠️    | ✅      |
| ------------ IfcDuctSilencer                        | ✅      | ✅    |        |
| ------------   IfcElectricFlowTreatmentDevice       |        | ✅    |        |
| ------------ IfcFilter                              | ✅      | ✅    |        |
| ------------ IfcInterceptor                         | ✅      | ✅    |        |
| ------   IfcDistributionControlElement              | ✅      | ✅    | ✅      |
| --------- IfcActuator                               | ✅      | ✅    |        |
| --------- IfcAlarm                                  | ✅      | ✅    |        |
| --------- IfcController                             | ✅      | ✅    |        |
| --------- IfcFlowInstrument                         | ✅      | ✅    |        |
| ---------   IfcProtectiveDeviceTrippingUnit         |        | ✅    | ✅      |
| --------- IfcSensor                                 | ✅      | ✅    |        |
| ---------   IfcUnitaryControlElement                | ✅      | ✅    |        |
| --- IfcCivilElement                                 | 🚫      | ✅    |        |
| --- IfcElementAssembly                              | ✅      | ✅    | ✅      |
| ---   IfcBuildingElementComponent                   |        |      | ✅      |
| --- IfcElementComponent                             | ⚠️      | ⚠️    |        |
| ------ IfcBuildingElementPart                       | ✅      | ✅    |        |
| ------ IfcDiscreteAccessory                         | ✅      | ✅    |        |
| ------ IfcFastener                                  | ✅      | ✅    |        |
| ------   IfcImpactProtectionDevice                  | ✅      |      |        |
| ------ IfcMechanicalFastener                        | ✅      | ✅    |        |
| ------ IfcReinforcingElement                        | ⚠️      | ⚠️    |        |
| --------- IfcReinforcingBar                         | ✅      | ✅    |        |
| --------- IfcReinforcingMesh                        | ✅      | ✅    |        |
| --------- IfcTendon                                 | ✅      | ✅    |        |
| --------- IfcTendonAnchor                           | ✅      | ✅    |        |
| --------- IfcTendonConduit                          | ✅      |      |        |
| ------ IfcSign                                      | ✅      |      |        |
| ------ IfcVibrationDamper                           | ✅      |      |        |
| ------ IfcVibrationIsolator                         | ✅      | ✅    |        |
| --- IfcFeatureElement                               | ⚠️      | ⚠️    | ✅      |
| ------   IfcFeatureElementAddition                  | ⚠️      | ⚠️    | ✅      |
| --------- IfcProjectionElement                      | ✅      | ✅    | ✅      |
| ------   IfcFeatureElementSubtraction               | ⚠️      | ⚠️    | ✅      |
| --------- IfcEarthworksCut                          | ✅      |      |        |
| --------- IfcOpeningElement                         | ✅      | ✅    | ✅      |
| --------- IfcVoidingFeature                         | ✅      | ✅    |        |
| ------ IfcSurfaceFeature                            | ✅      | ✅    |        |
| --- IfcFurnishingElement                            | ✅      | ✅    | ✅      |
| ------ IfcFurniture                                 | ✅      | ✅    |        |
| ------   IfcSystemFurnitureElement                  | ✅      | ✅    |        |
| --- IfcGeographicElement                            | ✅      | ✅    |        |
| --- IfcGeotechnicalElement                          | ⚠️      |      |        |
| ------ IfcGeotechnicalAssembly                      | ⚠️      |      |        |
| --------- IfcBorehole                               | ✅      |      |        |
| --------- IfcGeomodel                               | ✅      |      |        |
| --------- IfcGeoslice                               | ✅      |      |        |
| ------ IfcGeotechnicalStratum                       | ✅      |      |        |
| --- IfcTransportationDevice                         | ⚠️      |      |        |
| ------ IfcTransportElement                          | ✅      | ✅    | ✅      |
| ------ IfcVehicle                                   | ✅      |      |        |
| --- IfcVirtualElement                               | ✅      | ✅    | ✅      |
| --- IfcElectricalElement                            |        |      | 🚫      |
| --- IfcEquipmentElement                             |        |      | ✅      |

✅ - included in IFC version \
⚠️ - included but abstract, can't be instantiated \
🚫 - deprecated

### Listings of IfcElement sub-entities in different IFC versions

**Comma-separated IfcElement subentities in IFC4X3:**
```
IFCACTUATOR,IFCAIRTERMINAL,IFCAIRTERMINALBOX,IFCAIRTOAIRHEATRECOVERY,IFCALARM,IFCAUDIOVISUALAPPLIANCE,IFCBEAM,IFCBEARING,IFCBOILER,IFCBOREHOLE,IFCBUILDINGELEMENTPART,IFCBUILDINGELEMENTPROXY,IFCBUILTELEMENT,IFCBURNER,IFCCABLECARRIERFITTING,IFCCABLECARRIERSEGMENT,IFCCABLEFITTING,IFCCABLESEGMENT,IFCCAISSONFOUNDATION,IFCCHILLER,IFCCHIMNEY,IFCCOIL,IFCCOLUMN,IFCCOMMUNICATIONSAPPLIANCE,IFCCOMPRESSOR,IFCCONDENSER,IFCCONTROLLER,IFCCONVEYORSEGMENT,IFCCOOLEDBEAM,IFCCOOLINGTOWER,IFCCOURSE,IFCCOVERING,IFCCURTAINWALL,IFCDAMPER,IFCDEEPFOUNDATION,IFCDISCRETEACCESSORY,IFCDISTRIBUTIONBOARD,IFCDISTRIBUTIONCHAMBERELEMENT,IFCDISTRIBUTIONCONTROLELEMENT,IFCDISTRIBUTIONELEMENT,IFCDISTRIBUTIONFLOWELEMENT,IFCDOOR,IFCDUCTFITTING,IFCDUCTSEGMENT,IFCDUCTSILENCER,IFCEARTHWORKSCUT,IFCEARTHWORKSELEMENT,IFCEARTHWORKSFILL,IFCELECTRICAPPLIANCE,IFCELECTRICFLOWSTORAGEDEVICE,IFCELECTRICFLOWTREATMENTDEVICE,IFCELECTRICGENERATOR,IFCELECTRICMOTOR,IFCELECTRICTIMECONTROL,IFCELEMENTASSEMBLY,IFCENERGYCONVERSIONDEVICE,IFCENGINE,IFCEVAPORATIVECOOLER,IFCEVAPORATOR,IFCFAN,IFCFASTENER,IFCFILTER,IFCFIRESUPPRESSIONTERMINAL,IFCFLOWCONTROLLER,IFCFLOWFITTING,IFCFLOWINSTRUMENT,IFCFLOWMETER,IFCFLOWMOVINGDEVICE,IFCFLOWSEGMENT,IFCFLOWSTORAGEDEVICE,IFCFLOWTERMINAL,IFCFLOWTREATMENTDEVICE,IFCFOOTING,IFCFURNISHINGELEMENT,IFCFURNITURE,IFCGEOGRAPHICELEMENT,IFCGEOMODEL,IFCGEOSLICE,IFCGEOTECHNICALSTRATUM,IFCHEATEXCHANGER,IFCHUMIDIFIER,IFCIMPACTPROTECTIONDEVICE,IFCINTERCEPTOR,IFCJUNCTIONBOX,IFCKERB,IFCLAMP,IFCLIGHTFIXTURE,IFCLIQUIDTERMINAL,IFCMECHANICALFASTENER,IFCMEDICALDEVICE,IFCMEMBER,IFCMOBILETELECOMMUNICATIONSAPPLIANCE,IFCMOORINGDEVICE,IFCMOTORCONNECTION,IFCNAVIGATIONELEMENT,IFCOPENINGELEMENT,IFCOUTLET,IFCPAVEMENT,IFCPILE,IFCPIPEFITTING,IFCPIPESEGMENT,IFCPLATE,IFCPROJECTIONELEMENT,IFCPROTECTIVEDEVICE,IFCPROTECTIVEDEVICETRIPPINGUNIT,IFCPUMP,IFCRAIL,IFCRAILING,IFCRAMP,IFCRAMPFLIGHT,IFCREINFORCEDSOIL,IFCREINFORCINGBAR,IFCREINFORCINGMESH,IFCROOF,IFCSANITARYTERMINAL,IFCSENSOR,IFCSHADINGDEVICE,IFCSIGN,IFCSIGNAL,IFCSLAB,IFCSOLARDEVICE,IFCSPACEHEATER,IFCSTACKTERMINAL,IFCSTAIR,IFCSTAIRFLIGHT,IFCSURFACEFEATURE,IFCSWITCHINGDEVICE,IFCSYSTEMFURNITUREELEME,IFCTANK,IFCTENDON,IFCTENDONANCHOR,IFCTENDONCONDUIT,IFCTRACKELEMENT,IFCTRANSFORMER,IFCTRANSPORTELEMENT,IFCTUBEBUNDLE,IFCUNITARYCONTROLELEMENT,IFCUNITARYEQUIPMENT,IFCVALVE,IFCVEHICLE,IFCVIBRATIONDAMPER,IFCVIBRATIONISOLATOR,IFCVIRTUALELEMENT,IFCVOIDINGFEATURE,IFCWALL,IFCWASTETERMINAL,IFCWINDOW
```

<details><summary>✂️  IfcElement subentities in IFC4X3 as IDS entity facet</summary>

```
<ids:entity>
    <ids:name>
        <xs:restriction base="xs:string">
            <xs:enumeration value="IFCACTUATOR" />
            <xs:enumeration value="IFCAIRTERMINAL" />
            <xs:enumeration value="IFCAIRTERMINALBOX" />
            <xs:enumeration value="IFCAIRTOAIRHEATRECOVERY" />
            <xs:enumeration value="IFCALARM" />
            <xs:enumeration value="IFCAUDIOVISUALAPPLIANCE" />
            <xs:enumeration value="IFCBEAM" />
            <xs:enumeration value="IFCBEARING" />
            <xs:enumeration value="IFCBOILER" />
            <xs:enumeration value="IFCBOREHOLE" />
            <xs:enumeration value="IFCBUILDINGELEMENTPART" />
            <xs:enumeration value="IFCBUILDINGELEMENTPROXY" />
            <xs:enumeration value="IFCBUILTELEMENT" />
            <xs:enumeration value="IFCBURNER" />
            <xs:enumeration value="IFCCABLECARRIERFITTING" />
            <xs:enumeration value="IFCCABLECARRIERSEGMENT" />
            <xs:enumeration value="IFCCABLEFITTING" />
            <xs:enumeration value="IFCCABLESEGMENT" />
            <xs:enumeration value="IFCCAISSONFOUNDATION" />
            <xs:enumeration value="IFCCHILLER" />
            <xs:enumeration value="IFCCHIMNEY" />
            <xs:enumeration value="IFCCOIL" />
            <xs:enumeration value="IFCCOLUMN" />
            <xs:enumeration value="IFCCOMMUNICATIONSAPPLIANCE" />
            <xs:enumeration value="IFCCOMPRESSOR" />
            <xs:enumeration value="IFCCONDENSER" />
            <xs:enumeration value="IFCCONTROLLER" />
            <xs:enumeration value="IFCCONVEYORSEGMENT" />
            <xs:enumeration value="IFCCOOLEDBEAM" />
            <xs:enumeration value="IFCCOOLINGTOWER" />
            <xs:enumeration value="IFCCOURSE" />
            <xs:enumeration value="IFCCOVERING" />
            <xs:enumeration value="IFCCURTAINWALL" />
            <xs:enumeration value="IFCDAMPER" />
            <xs:enumeration value="IFCDEEPFOUNDATION" />
            <xs:enumeration value="IFCDISCRETEACCESSORY" />
            <xs:enumeration value="IFCDISTRIBUTIONBOARD" />
            <xs:enumeration value="IFCDISTRIBUTIONCHAMBERELEMENT" />
            <xs:enumeration value="IFCDISTRIBUTIONCONTROLELEMENT" />
            <xs:enumeration value="IFCDISTRIBUTIONELEMENT" />
            <xs:enumeration value="IFCDISTRIBUTIONFLOWELEMENT" />
            <xs:enumeration value="IFCDOOR" />
            <xs:enumeration value="IFCDUCTFITTING" />
            <xs:enumeration value="IFCDUCTSEGMENT" />
            <xs:enumeration value="IFCDUCTSILENCER" />
            <xs:enumeration value="IFCEARTHWORKSCUT" />
            <xs:enumeration value="IFCEARTHWORKSELEMENT" />
            <xs:enumeration value="IFCEARTHWORKSFILL" />
            <xs:enumeration value="IFCELECTRICAPPLIANCE" />
            <xs:enumeration value="IFCELECTRICFLOWSTORAGEDEVICE" />
            <xs:enumeration value="IFCELECTRICFLOWTREATMENTDEVICE" />
            <xs:enumeration value="IFCELECTRICGENERATOR" />
            <xs:enumeration value="IFCELECTRICMOTOR" />
            <xs:enumeration value="IFCELECTRICTIMECONTROL" />
            <xs:enumeration value="IFCELEMENTASSEMBLY" />
            <xs:enumeration value="IFCENERGYCONVERSIONDEVICE" />
            <xs:enumeration value="IFCENGINE" />
            <xs:enumeration value="IFCEVAPORATIVECOOLER" />
            <xs:enumeration value="IFCEVAPORATOR" />
            <xs:enumeration value="IFCFAN" />
            <xs:enumeration value="IFCFASTENER" />
            <xs:enumeration value="IFCFILTER" />
            <xs:enumeration value="IFCFIRESUPPRESSIONTERMINAL" />
            <xs:enumeration value="IFCFLOWCONTROLLER" />
            <xs:enumeration value="IFCFLOWFITTING" />
            <xs:enumeration value="IFCFLOWINSTRUMENT" />
            <xs:enumeration value="IFCFLOWMETER" />
            <xs:enumeration value="IFCFLOWMOVINGDEVICE" />
            <xs:enumeration value="IFCFLOWSEGMENT" />
            <xs:enumeration value="IFCFLOWSTORAGEDEVICE" />
            <xs:enumeration value="IFCFLOWTERMINAL" />
            <xs:enumeration value="IFCFLOWTREATMENTDEVICE" />
            <xs:enumeration value="IFCFOOTING" />
            <xs:enumeration value="IFCFURNISHINGELEMENT" />
            <xs:enumeration value="IFCFURNITURE" />
            <xs:enumeration value="IFCGEOGRAPHICELEMENT" />
            <xs:enumeration value="IFCGEOMODEL" />
            <xs:enumeration value="IFCGEOSLICE" />
            <xs:enumeration value="IFCGEOTECHNICALSTRATUM" />
            <xs:enumeration value="IFCHEATEXCHANGER" />
            <xs:enumeration value="IFCHUMIDIFIER" />
            <xs:enumeration value="IFCIMPACTPROTECTIONDEVICE" />
            <xs:enumeration value="IFCINTERCEPTOR" />
            <xs:enumeration value="IFCJUNCTIONBOX" />
            <xs:enumeration value="IFCKERB" />
            <xs:enumeration value="IFCLAMP" />
            <xs:enumeration value="IFCLIGHTFIXTURE" />
            <xs:enumeration value="IFCLIQUIDTERMINAL" />
            <xs:enumeration value="IFCMECHANICALFASTENER" />
            <xs:enumeration value="IFCMEDICALDEVICE" />
            <xs:enumeration value="IFCMEMBER" />
            <xs:enumeration value="IFCMOBILETELECOMMUNICATIONSAPPLIANCE" />
            <xs:enumeration value="IFCMOORINGDEVICE" />
            <xs:enumeration value="IFCMOTORCONNECTION" />
            <xs:enumeration value="IFCNAVIGATIONELEMENT" />
            <xs:enumeration value="IFCOPENINGELEMENT" />
            <xs:enumeration value="IFCOUTLET" />
            <xs:enumeration value="IFCPAVEMENT" />
            <xs:enumeration value="IFCPILE" />
            <xs:enumeration value="IFCPIPEFITTING" />
            <xs:enumeration value="IFCPIPESEGMENT" />
            <xs:enumeration value="IFCPLATE" />
            <xs:enumeration value="IFCPROJECTIONELEMENT" />
            <xs:enumeration value="IFCPROTECTIVEDEVICE" />
            <xs:enumeration value="IFCPROTECTIVEDEVICETRIPPINGUNIT" />
            <xs:enumeration value="IFCPUMP" />
            <xs:enumeration value="IFCRAIL" />
            <xs:enumeration value="IFCRAILING" />
            <xs:enumeration value="IFCRAMP" />
            <xs:enumeration value="IFCRAMPFLIGHT" />
            <xs:enumeration value="IFCREINFORCEDSOIL" />
            <xs:enumeration value="IFCREINFORCINGBAR" />
            <xs:enumeration value="IFCREINFORCINGMESH" />
            <xs:enumeration value="IFCROOF" />
            <xs:enumeration value="IFCSANITARYTERMINAL" />
            <xs:enumeration value="IFCSENSOR" />
            <xs:enumeration value="IFCSHADINGDEVICE" />
            <xs:enumeration value="IFCSIGN" />
            <xs:enumeration value="IFCSIGNAL" />
            <xs:enumeration value="IFCSLAB" />
            <xs:enumeration value="IFCSOLARDEVICE" />
            <xs:enumeration value="IFCSPACEHEATER" />
            <xs:enumeration value="IFCSTACKTERMINAL" />
            <xs:enumeration value="IFCSTAIR" />
            <xs:enumeration value="IFCSTAIRFLIGHT" />
            <xs:enumeration value="IFCSURFACEFEATURE" />
            <xs:enumeration value="IFCSWITCHINGDEVICE" />
            <xs:enumeration value="IFCSYSTEMFURNITUREELEME" />
            <xs:enumeration value="IFCTANK" />
            <xs:enumeration value="IFCTENDON" />
            <xs:enumeration value="IFCTENDONANCHOR" />
            <xs:enumeration value="IFCTENDONCONDUIT" />
            <xs:enumeration value="IFCTRACKELEMENT" />
            <xs:enumeration value="IFCTRANSFORMER" />
            <xs:enumeration value="IFCTRANSPORTELEMENT" />
            <xs:enumeration value="IFCTUBEBUNDLE" />
            <xs:enumeration value="IFCUNITARYCONTROLELEMENT" />
            <xs:enumeration value="IFCUNITARYEQUIPMENT" />
            <xs:enumeration value="IFCVALVE" />
            <xs:enumeration value="IFCVEHICLE" />
            <xs:enumeration value="IFCVIBRATIONDAMPER" />
            <xs:enumeration value="IFCVIBRATIONISOLATOR" />
            <xs:enumeration value="IFCVIRTUALELEMENT" />
            <xs:enumeration value="IFCVOIDINGFEATURE" />
            <xs:enumeration value="IFCWALL" />
            <xs:enumeration value="IFCWASTETERMINAL" />
            <xs:enumeration value="IFCWINDOW" />
        </xs:restriction>
    </ids:name>
</ids:entity>
```
</details>

**Comma-separated IfcElement subentities in IFC4:**
```
IFCBEAM,IFCACTUATOR,IFCAIRTERMINAL,IFCAIRTERMINALBOX,IFCAIRTOAIRHEATRECOVERY,IFCALARM,IFCAUDIOVISUALAPPLIANCE,IFCBOILER,IFCBUILDINGELEMENTPART,IFCBUILDINGELEMENTPROXY,IFCBURNER,IFCCABLECARRIERFITTING,IFCCABLECARRIERSEGMENT,IFCCABLEFITTING,IFCCABLESEGMENT,IFCCHILLER,IFCCHIMNEY,IFCCIVILELEMENT,IFCCOIL,IFCCOLUMN,IFCCOMMUNICATIONSAPPLIANCE,IFCCOMPRESSOR,IFCCONDENSER,IFCCONTROLLER,IFCCOOLEDBEAM,IFCCOOLINGTOWER,IFCCOVERING,IFCCURTAINWALL,IFCDAMPER,IFCDISCRETEACCESSORY,IFCDISTRIBUTIONCHAMBERELEMENT,IFCDISTRIBUTIONCONTROLELEMENT,IFCDISTRIBUTIONELEMENT,IFCDISTRIBUTIONFLOWELEMENT,IFCDOOR,IFCDUCTFITTING,IFCDUCTSEGMENT,IFCDUCTSILENCER,IFCELECTRICAPPLIANCE,IFCELECTRICDISTRIBUTIONBOARD,IFCELECTRICFLOWSTORAGEDEVICE,IFCELECTRICGENERATOR,IFCELECTRICMOTOR,IFCELECTRICTIMECONTROL,IFCELEMENTASSEMBLY,IFCENGINE,IFCEVAPORATIVECOOLER,IFCEVAPORATOR,IFCFAN,IFCFASTENER,IFCFILTER,IFCFIRESUPPRESSIONTERMINAL,IFCFLOWINSTRUMENT,IFCFLOWMETER,IFCFOOTING,IFCFURNISHINGELEMENT,IFCFURNITURE,IFCGEOGRAPHICELEMENT,IFCHEATEXCHANGER,IFCHUMIDIFIER,IFCINTERCEPTOR,IFCJUNCTIONBOX,IFCLAMP,IFCLIGHTFIXTURE,IFCMECHANICALFASTENER,IFCMEDICALDEVICE,IFCMEMBER,IFCMOTORCONNECTION,IFCOPENINGELEMENT,IFCOUTLET,IFCPILE,IFCPIPEFITTING,IFCPIPESEGMENT,IFCPLATE,IFCPROJECTIONELEMENT,IFCPROTECTIVEDEVICE,IFCPROTECTIVEDEVICETRIPPINGUNIT,IFCPUMP,IFCRAILING,IFCRAMP,IFCRAMPFLIGHT,IFCREINFORCINGBAR,IFCREINFORCINGMESH,IFCROOF,IFCSANITARYTERMINAL,IFCSENSOR,IFCSHADINGDEVICE,IFCSLAB,IFCSOLARDEVICE,IFCSPACEHEATER,IFCSTACKTERMINAL,IFCSTAIR,IFCSTAIRFLIGHT,IFCSURFACEFEATURE,IFCSWITCHINGDEVICE,IFCSYSTEMFURNITUREELEME,IFCTANK,IFCTENDON,IFCTENDONANCHOR,IFCTRANSFORMER,IFCTRANSPORTELEMENT,IFCTUBEBUNDLE,IFCUNITARYCONTROLELEMENT,IFCUNITARYEQUIPMENT,IFCVALVE,IFCVIBRATIONISOLATOR,IFCVIRTUALELEMENT,IFCVOIDINGFEATURE,IFCWALL,IFCWASTETERMINAL,IFCWINDOW
```

<details><summary>✂️  IfcElement subentities in IFC4 as IDS entity facet</summary>

```
<ids:entity>
    <ids:name>
        <xs:restriction base="xs:string">
            <xs:enumeration value="IFCBEAM" />
            <xs:enumeration value="IFCACTUATOR" />
            <xs:enumeration value="IFCAIRTERMINAL" />
            <xs:enumeration value="IFCAIRTERMINALBOX" />
            <xs:enumeration value="IFCAIRTOAIRHEATRECOVERY" />
            <xs:enumeration value="IFCALARM" />
            <xs:enumeration value="IFCAUDIOVISUALAPPLIANCE" />
            <xs:enumeration value="IFCBOILER" />
            <xs:enumeration value="IFCBUILDINGELEMENTPART" />
            <xs:enumeration value="IFCBUILDINGELEMENTPROXY" />
            <xs:enumeration value="IFCBURNER" />
            <xs:enumeration value="IFCCABLECARRIERFITTING" />
            <xs:enumeration value="IFCCABLECARRIERSEGMENT" />
            <xs:enumeration value="IFCCABLEFITTING" />
            <xs:enumeration value="IFCCABLESEGMENT" />
            <xs:enumeration value="IFCCHILLER" />
            <xs:enumeration value="IFCCHIMNEY" />
            <xs:enumeration value="IFCCIVILELEMENT" />
            <xs:enumeration value="IFCCOIL" />
            <xs:enumeration value="IFCCOLUMN" />
            <xs:enumeration value="IFCCOMMUNICATIONSAPPLIANCE" />
            <xs:enumeration value="IFCCOMPRESSOR" />
            <xs:enumeration value="IFCCONDENSER" />
            <xs:enumeration value="IFCCONTROLLER" />
            <xs:enumeration value="IFCCOOLEDBEAM" />
            <xs:enumeration value="IFCCOOLINGTOWER" />
            <xs:enumeration value="IFCCOVERING" />
            <xs:enumeration value="IFCCURTAINWALL" />
            <xs:enumeration value="IFCDAMPER" />
            <xs:enumeration value="IFCDISCRETEACCESSORY" />
            <xs:enumeration value="IFCDISTRIBUTIONCHAMBERELEMENT" />
            <xs:enumeration value="IFCDISTRIBUTIONCONTROLELEMENT" />
            <xs:enumeration value="IFCDISTRIBUTIONELEMENT" />
            <xs:enumeration value="IFCDISTRIBUTIONFLOWELEMENT" />
            <xs:enumeration value="IFCDOOR" />
            <xs:enumeration value="IFCDUCTFITTING" />
            <xs:enumeration value="IFCDUCTSEGMENT" />
            <xs:enumeration value="IFCDUCTSILENCER" />
            <xs:enumeration value="IFCELECTRICAPPLIANCE" />
            <xs:enumeration value="IFCELECTRICDISTRIBUTIONBOARD" />
            <xs:enumeration value="IFCELECTRICFLOWSTORAGEDEVICE" />
            <xs:enumeration value="IFCELECTRICGENERATOR" />
            <xs:enumeration value="IFCELECTRICMOTOR" />
            <xs:enumeration value="IFCELECTRICTIMECONTROL" />
            <xs:enumeration value="IFCELEMENTASSEMBLY" />
            <xs:enumeration value="IFCENGINE" />
            <xs:enumeration value="IFCEVAPORATIVECOOLER" />
            <xs:enumeration value="IFCEVAPORATOR" />
            <xs:enumeration value="IFCFAN" />
            <xs:enumeration value="IFCFASTENER" />
            <xs:enumeration value="IFCFILTER" />
            <xs:enumeration value="IFCFIRESUPPRESSIONTERMINAL" />
            <xs:enumeration value="IFCFLOWINSTRUMENT" />
            <xs:enumeration value="IFCFLOWMETER" />
            <xs:enumeration value="IFCFOOTING" />
            <xs:enumeration value="IFCFURNISHINGELEMENT" />
            <xs:enumeration value="IFCFURNITURE" />
            <xs:enumeration value="IFCGEOGRAPHICELEMENT" />
            <xs:enumeration value="IFCHEATEXCHANGER" />
            <xs:enumeration value="IFCHUMIDIFIER" />
            <xs:enumeration value="IFCINTERCEPTOR" />
            <xs:enumeration value="IFCJUNCTIONBOX" />
            <xs:enumeration value="IFCLAMP" />
            <xs:enumeration value="IFCLIGHTFIXTURE" />
            <xs:enumeration value="IFCMECHANICALFASTENER" />
            <xs:enumeration value="IFCMEDICALDEVICE" />
            <xs:enumeration value="IFCMEMBER" />
            <xs:enumeration value="IFCMOTORCONNECTION" />
            <xs:enumeration value="IFCOPENINGELEMENT" />
            <xs:enumeration value="IFCOUTLET" />
            <xs:enumeration value="IFCPILE" />
            <xs:enumeration value="IFCPIPEFITTING" />
            <xs:enumeration value="IFCPIPESEGMENT" />
            <xs:enumeration value="IFCPLATE" />
            <xs:enumeration value="IFCPROJECTIONELEMENT" />
            <xs:enumeration value="IFCPROTECTIVEDEVICE" />
            <xs:enumeration value="IFCPROTECTIVEDEVICETRIPPINGUNIT" />
            <xs:enumeration value="IFCPUMP" />
            <xs:enumeration value="IFCRAILING" />
            <xs:enumeration value="IFCRAMP" />
            <xs:enumeration value="IFCRAMPFLIGHT" />
            <xs:enumeration value="IFCREINFORCINGBAR" />
            <xs:enumeration value="IFCREINFORCINGMESH" />
            <xs:enumeration value="IFCROOF" />
            <xs:enumeration value="IFCSANITARYTERMINAL" />
            <xs:enumeration value="IFCSENSOR" />
            <xs:enumeration value="IFCSHADINGDEVICE" />
            <xs:enumeration value="IFCSLAB" />
            <xs:enumeration value="IFCSOLARDEVICE" />
            <xs:enumeration value="IFCSPACEHEATER" />
            <xs:enumeration value="IFCSTACKTERMINAL" />
            <xs:enumeration value="IFCSTAIR" />
            <xs:enumeration value="IFCSTAIRFLIGHT" />
            <xs:enumeration value="IFCSURFACEFEATURE" />
            <xs:enumeration value="IFCSWITCHINGDEVICE" />
            <xs:enumeration value="IFCSYSTEMFURNITUREELEME" />
            <xs:enumeration value="IFCTANK" />
            <xs:enumeration value="IFCTENDON" />
            <xs:enumeration value="IFCTENDONANCHOR" />
            <xs:enumeration value="IFCTRANSFORMER" />
            <xs:enumeration value="IFCTRANSPORTELEMENT" />
            <xs:enumeration value="IFCTUBEBUNDLE" />
            <xs:enumeration value="IFCUNITARYCONTROLELEMENT" />
            <xs:enumeration value="IFCUNITARYEQUIPMENT" />
            <xs:enumeration value="IFCVALVE" />
            <xs:enumeration value="IFCVIBRATIONISOLATOR" />
            <xs:enumeration value="IFCVIRTUALELEMENT" />
            <xs:enumeration value="IFCVOIDINGFEATURE" />
            <xs:enumeration value="IFCWALL" />
            <xs:enumeration value="IFCWASTETERMINAL" />
            <xs:enumeration value="IFCWINDOW" />
        </xs:restriction>
    </ids:name>
</ids:entity>
```
</details>

**Comma-separated IfcElement subentities in IFC2X3:**
```
IFCELEMENT,IFCBUILDINGELEMENT,IFCBUILDINGELEMENTPROXY,IFCCOVERING,IFCBEAM,IFCCOLUMN,IFCCURTAINWALL,IFCDOOR,IFCMEMBER,IFCRAILING,IFCRAMP,IFCRAMPFLIGHT,IFCWALL,IFCSLAB,IFCSTAIRFLIGHT,IFCWINDOW,IFCSTAIR,IFCROOF,IFCPILE,IFCFOOTING,IFCBUILDINGELEMENTCOMPONENT,IFCPLATE,IFCFURNISHINGELEMENT,IFCDISTRIBUTIONELEMENT,IFCDISTRIBUTIONFLOWELEMENT,IFCFLOWFITTING,IFCFLOWSEGMENT,IFCFLOWCONTROLLER,IFCFLOWTERMINAL,IFCFLOWMOVINGDEVICE,IFCENERGYCONVERSIONDEVICE,IFCFLOWSTORAGEDEVICE,IFCFLOWTREATMENTDEVICE,IFCDISTRIBUTIONCHAMBERELEMENT,IFCDISTRIBUTIONCONTROLELEMENT,IFCTRANSPORTELEMENT,IFCEQUIPMENTELEMENT,IFCFEATUREELEMENT,IFCFEATUREELEMENTADDITION,IFCPROJECTIONELEMENT,IFCFEATUREELEMENTSUBTRACTION,IFCOPENINGELEMENT,IFCELEMENTASSEMBLY,IFCVIRTUALELEMENT
```

<details><summary>✂️  IfcElement subentities in IFC2X3 as IDS entity facet</summary>

```
<ids:entity>
    <ids:name>
        <xs:restriction base="xs:string">
            <xs:enumeration value="IFCELEMENT" />
            <xs:enumeration value="IFCBUILDINGELEMENT" />
            <xs:enumeration value="IFCBUILDINGELEMENTPROXY" />
            <xs:enumeration value="IFCCOVERING" />
            <xs:enumeration value="IFCBEAM" />
            <xs:enumeration value="IFCCOLUMN" />
            <xs:enumeration value="IFCCURTAINWALL" />
            <xs:enumeration value="IFCDOOR" />
            <xs:enumeration value="IFCMEMBER" />
            <xs:enumeration value="IFCRAILING" />
            <xs:enumeration value="IFCRAMP" />
            <xs:enumeration value="IFCRAMPFLIGHT" />
            <xs:enumeration value="IFCWALL" />
            <xs:enumeration value="IFCSLAB" />
            <xs:enumeration value="IFCSTAIRFLIGHT" />
            <xs:enumeration value="IFCWINDOW" />
            <xs:enumeration value="IFCSTAIR" />
            <xs:enumeration value="IFCROOF" />
            <xs:enumeration value="IFCPILE" />
            <xs:enumeration value="IFCFOOTING" />
            <xs:enumeration value="IFCBUILDINGELEMENTCOMPONENT" />
            <xs:enumeration value="IFCPLATE" />
            <xs:enumeration value="IFCFURNISHINGELEMENT" />
            <xs:enumeration value="IFCDISTRIBUTIONELEMENT" />
            <xs:enumeration value="IFCDISTRIBUTIONFLOWELEMENT" />
            <xs:enumeration value="IFCFLOWFITTING" />
            <xs:enumeration value="IFCFLOWSEGMENT" />
            <xs:enumeration value="IFCFLOWCONTROLLER" />
            <xs:enumeration value="IFCFLOWTERMINAL" />
            <xs:enumeration value="IFCFLOWMOVINGDEVICE" />
            <xs:enumeration value="IFCENERGYCONVERSIONDEVICE" />
            <xs:enumeration value="IFCFLOWSTORAGEDEVICE" />
            <xs:enumeration value="IFCFLOWTREATMENTDEVICE" />
            <xs:enumeration value="IFCDISTRIBUTIONCHAMBERELEMENT" />
            <xs:enumeration value="IFCDISTRIBUTIONCONTROLELEMENT" />
            <xs:enumeration value="IFCTRANSPORTELEMENT" />
            <xs:enumeration value="IFCEQUIPMENTELEMENT" />
            <xs:enumeration value="IFCFEATUREELEMENT" />
            <xs:enumeration value="IFCFEATUREELEMENTADDITION" />
            <xs:enumeration value="IFCPROJECTIONELEMENT" />
            <xs:enumeration value="IFCFEATUREELEMENTSUBTRACTION" />
            <xs:enumeration value="IFCOPENINGELEMENT" />
            <xs:enumeration value="IFCELEMENTASSEMBLY" />
            <xs:enumeration value="IFCVIRTUALELEMENT" />
        </xs:restriction>
    </ids:name>
</ids:entity>
```
</details>
