# IFC2X3 entities mapping

The following table lists all special cases for checking IFC2X3 models identification of model subsets is is further restricted by the type object.

The first column shows the name to be used in the IDS entity facet.
The second and third columns define the properties of matching IFC2X3 entity and type pair.

| Name in IDS facet            | Occurrence entity             | Type entity                      |
| ---------------------------- | ----------------------------- | -------------------------------- |
| IfcFurniture                 | IfcFurnishingElement          | IfcFurnitureType                 |
| IfcSystemFurnitureElement    | IfcFurnishingElement          | IfcSystemFurnitureElementType    |
| IfcActuator                  | IfcDistributionControlElement | IfcActuatorType                  |
| IfcAlarm                     | IfcDistributionControlElement | IfcAlarmType                     |
| IfcController                | IfcDistributionControlElement | IfcControllerType                |
| IfcFlowInstrument            | IfcDistributionControlElement | IfcFlowInstrumentType            |
| IfcSensor                    | IfcDistributionControlElement | IfcSensorType                    |
| IfcAirToAirHeatRecovery      | IfcEnergyConversionDevice     | IfcAirToAirHeatRecoveryType      |
| IfcBoiler                    | IfcEnergyConversionDevice     | IfcBoilerType                    |
| IfcChiller                   | IfcEnergyConversionDevice     | IfcChillerType                   |
| IfcCoil                      | IfcEnergyConversionDevice     | IfcCoilType                      |
| IfcCondenser                 | IfcEnergyConversionDevice     | IfcCondenserType                 |
| IfcCooledBeam                | IfcEnergyConversionDevice     | IfcCooledBeamType                |
| IfcCoolingTower              | IfcEnergyConversionDevice     | IfcCoolingTowerType              |
| IfcElectricGenerator         | IfcEnergyConversionDevice     | IfcElectricGeneratorType         |
| IfcElectricMotor             | IfcEnergyConversionDevice     | IfcElectricMotorType             |
| IfcEvaporativeCooler         | IfcEnergyConversionDevice     | IfcEvaporativeCoolerType         |
| IfcEvaporator                | IfcEnergyConversionDevice     | IfcEvaporatorType                |
| IfcHeatExchanger             | IfcEnergyConversionDevice     | IfcHeatExchangerType             |
| IfcHumidifier                | IfcEnergyConversionDevice     | IfcHumidifierType                |
| IfcMotorConnection           | IfcEnergyConversionDevice     | IfcMotorConnectionType           |
| IfcSpaceHeater               | IfcEnergyConversionDevice     | IfcSpaceHeaterType               |
| IfcTransformer               | IfcEnergyConversionDevice     | IfcTransformerType               |
| IfcTubeBundle                | IfcEnergyConversionDevice     | IfcTubeBundleType                |
| IfcUnitaryEquipment          | IfcEnergyConversionDevice     | IfcUnitaryEquipmentType          |
| IfcAirTerminalBox            | IfcFlowController             | IfcAirTerminalBoxType            |
| IfcDamper                    | IfcFlowController             | IfcDamperType                    |
| IfcElectricTimeControl       | IfcFlowController             | IfcElectricTimeControlType       |
| IfcFlowMeter                 | IfcFlowController             | IfcFlowMeterType                 |
| IfcProtectiveDevice          | IfcFlowController             | IfcProtectiveDeviceType          |
| IfcSwitchingDevice           | IfcFlowController             | IfcSwitchingDeviceType           |
| IfcValve                     | IfcFlowController             | IfcValveType                     |
| IfcCableCarrierFitting       | IfcFlowFitting                | IfcCableCarrierFittingType       |
| IfcDuctFitting               | IfcFlowFitting                | IfcDuctFittingType               |
| IfcJunctionBox               | IfcFlowFitting                | IfcJunctionBoxType               |
| IfcPipeFitting               | IfcFlowFitting                | IfcPipeFittingType               |
| IfcCompressor                | IfcFlowMovingDevice           | IfcCompressorType                |
| IfcFan                       | IfcFlowMovingDevice           | IfcFanType                       |
| IfcPump                      | IfcFlowMovingDevice           | IfcPumpType                      |
| IfcCableCarrierSegment       | IfcFlowSegment                | IfcCableCarrierSegmentType       |
| IfcCableSegment              | IfcFlowSegment                | IfcCableSegmentType              |
| IfcDuctSegment               | IfcFlowSegment                | IfcDuctSegmentType               |
| IfcPipeSegment               | IfcFlowSegment                | IfcPipeSegmentType               |
| IfcElectricFlowStorageDevice | IfcFlowStorageDevice          | IfcElectricFlowStorageDeviceType |
| IfcTank                      | IfcFlowStorageDevice          | IfcTankType                      |
| IfcAirTerminal               | IfcFlowTerminal               | IfcAirTerminalType               |
| IfcElectricAppliance         | IfcFlowTerminal               | IfcElectricApplianceType         |
| IfcFireSuppressionTerminal   | IfcFlowTerminal               | IfcFireSuppressionTerminalType   |
| IfcLamp                      | IfcFlowTerminal               | IfcLampType                      |
| IfcLightFixture              | IfcFlowTerminal               | IfcLightFixtureType              |
| IfcOutlet                    | IfcFlowTerminal               | IfcOutletType                    |
| IfcSanitaryTerminal          | IfcFlowTerminal               | IfcSanitaryTerminalType          |
| IfcStackTerminal             | IfcFlowTerminal               | IfcStackTerminalType             |
| IfcWasteTerminal             | IfcFlowTerminal               | IfcWasteTerminalType             |
| IfcDuctSilencer              | IfcFlowTreatmentDevice        | IfcDuctSilencerType              |
| IfcFilter                    | IfcFlowTreatmentDevice        | IfcFilterType                    |
| IfcVibrationIsolator         | IfcEquipmentElement           | IfcVibrationIsolatorType         |

## Examples

For example, the definition of an IDS applicability facet with entity `IfcFilter`, should result in the identification of all `IfcFlowTreatmentDevice` that are associated with a type `IfcFilterType`.

Similarly, the definition of a requirement with entity name `IfcFilter` should fail if the entity type is different from `IfcFlowTreatmentDevice` or its type is not `IfcFilterType`.

## Notes

The history of these agreement can be traced in [#116](https://github.com/buildingSMART/IDS/issues/116).
