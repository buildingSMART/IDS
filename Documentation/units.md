Numerical values of physical quantities are represented using SI units. The following table lists the physical quantities and their units. 
A full list of IFC Defined types can be found in the IFC documentation. For example for IFC 4ADD2TC1 it is here: https://standards.buildingsmart.org/IFC/RELEASE/IFC4/ADD2_TC1/HTML/link/alphabeticalorder-defined-types.htm


| Ifc Defined Type name                | Physical Quantity description | Unit         | Unit Symbol | Dimensional exponents   | Unit enumeration                                   |
| ------------------------------------ | ----------------------------- | ------------ | ----------- | ----------------------- | -------------------------------------------------- | 
| IfcAmountOfSubstanceMeasure          | Amount of substance           | mole         | mol         | (0, 0, 0, 0, 0, 1, 0)   | IfcUnitEnum.AMOUNTOFSUBSTANCEUNIT                  | 
| IfcAreaDensityMeasure                | Area density                  |              | Kg/m2       | (-2, 1, 0, 0, 0, 0, 0)  | IfcDerivedUnitEnum.AREADENSITYUNIT                 | 
| IfcAreaMeasure                       | Area                          | square meter | m2          | (2, 0, 0, 0, 0, 0, 0)   | IfcUnitEnum.AREAUNIT                               | 
| IfcDynamicViscosityMeasure           | Dynamic viscosity             |              | Pa s        | (-1, 1, -1, 0, 0, 0, 0) | IfcDerivedUnitEnum.DYNAMICVISCOSITYUNIT            | 
| IfcElectricCapacitanceMeasure        | Electric capacitance          | farad        | F           | (-2, 1, 4, 1, 0, 0, 0)  | IfcUnitEnum.ELECTRICCAPACITANCEUNIT                | 
| IfcElectricChargeMeasure             | Electric charge               | coulomb      | C           | (0, 0, 1, 1, 0, 0, 0)   | IfcUnitEnum.ELECTRICCHARGEUNIT                     | 
| IfcElectricConductanceMeasure        | Electric conductance          | siemens      | S           | (-2, -1, 3, 2, 0, 0, 0) | IfcUnitEnum.ELECTRICCONDUCTANCEUNIT                | 
| IfcElectricCurrentMeasure            | Electric current              | ampere       | A           | (0, 0, 0, 1, 0, 0, 0)   | IfcUnitEnum.ELECTRICCURRENTUNIT                    | 
| IfcElectricResistanceMeasure         | Electric resistance           | ohm          | Ω           | (2, 1, -3, -2, 0, 0, 0) | IfcUnitEnum.ELECTRICRESISTANCEUNIT                 | 
| IfcElectricVoltageMeasure            | Electric voltage              | volt         | V           | (2, 1, -3, -1, 0, 0, 0) | IfcUnitEnum.ELECTRICVOLTAGEUNIT                    | 
| IfcEnergyMeasure                     | Energy                        | joule        | J           | (2, 1, -2, 0, 0, 0, 0)  | IfcUnitEnum.ENERGYUNIT                             | 
| IfcForceMeasure                      | Force                         | newton       | N           | (1, 1, -2, 0, 0, 0, 0)  | IfcUnitEnum.FORCEUNIT                              | 
| IfcFrequencyMeasure                  | Frequency                     | hertz        | Hz          | (0, 0, -1, 0, 0, 0, 0)  | IfcUnitEnum.FREQUENCYUNIT                          | 
| IfcHeatFluxDensityMeasure            | Heat flux density             |              | W/m2        | (0, 1, -3, 0, 0, 0, 0)  | IfcDerivedUnitEnum.HEATFLUXDENSITYUNIT             | 
| IfcHeatingValueMeasure               | Heating                       |              | J/K         | (2, 1, -2, 0, -1, 0, 0) | IfcDerivedUnitEnum.HEATINGVALUEUNIT                | 
| IfcIlluminanceMeasure                | Illuminance                   | lux          | lx          | (-2, 0, 0, 0, 0, 0, 1)  | IfcUnitEnum.ILLUMINANCEUNIT                        | 
| IfcIonConcentrationMeasure           | Ion concentration measure     |              | mol/m3      | (-3, 1, 0, 0, 0, 0, 0)  | IfcDerivedUnitEnum.IONCONCENTRATIONUNIT            | 
| IfcIsothermalMoistureCapacityMeasure | Iso thermal moisture capacity |              | m3/Kg       | (3, -1, 0, 0, 0, 0, 0)  | IfcDerivedUnitEnum.ISOTHERMALMOISTURECAPACITYUNIT  | 
| IfcLengthMeasure                     | Length                        | meter        | m           | (1, 0, 0, 0, 0, 0, 0)   | IfcUnitEnum.LENGTHUNIT                             | 
| IfcLinearVelocityMeasure             | Speed                         |              | m/s         | (1, 0, -1, 0, 0, 0, 0)  | IfcDerivedUnitEnum.LINEARVELOCITYUNIT              | 
| IfcLuminousFluxMeasure               | Luminous flux                 | Lumen        | lm          | (0, 0, 0, 0, 0, 0, 1)   | IfcUnitEnum.LUMINOUSFLUXUNIT                       | 
| IfcLuminousIntensityMeasure          | Luminous intensity            | candela      | cd          | (0, 0, 0, 0, 0, 0, 1)   | IfcUnitEnum.LUMINOUSINTENSITYUNIT                  | 
| IfcMassDensityMeasure                | Mass density                  |              | Kg/m3       | (-3, 1, 0, 0, 0, 0, 0)  | IfcDerivedUnitEnum.MASSDENSITYUNIT                 | 
| IfcMassFlowRateMeasure               | Mass flow rate                |              | Kg/s        | (0, 1, -1, 0, 0, 0, 0)  | IfcDerivedUnitEnum.MASSFLOWRATEUNIT                | 
| IfcMassMeasure                       | Mass                          | kilogram     | Kg          | (0, 1, 0, 0, 0, 0, 0)   | IfcUnitEnum.MASSUNIT                               | 
| IfcMassPerLengthMeasure              | Mass per length               |              | Kg/m        | (-1, 1, 0, 0, 0, 0, 0)  | IfcDerivedUnitEnum.MASSPERLENGTHUNIT               | 
| IfcModulusOfElasticityMeasure        | Modulus of elasticity         |              | N/m2        | (-1, 1, -2, 0, 0, 0, 0) | IfcDerivedUnitEnum.MODULUSOFELASTICITYUNIT         | 
| IfcMoistureDiffusivityMeasure        | Moisture diffusivity          |              | m3/s        | (3, 0, -1, 0, 0, 0, 0)  | IfcDerivedUnitEnum.MOISTUREDIFFUSIVITYUNIT         | 
| IfcMolecularWeightMeasure            | Molecular weight              |              | Kg/mol      | (0, 1, 0, 0, 0, -1, 0)  | IfcDerivedUnitEnum.MOLECULARWEIGHTUNIT             | 
| IfcMomentOfInertiaMeasure            | Moment of inertia             |              | m4          | (4, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.MOMENTOFINERTIAUNIT             | 
| IfcPHMeasure                         | PH                            |              | PH          | (0, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.PHUNIT                          | 
| IfcPlanarForceMeasure                | Planar force                  |              | Pa          | (-1, 1, -2, 0, 0, 0, 0) | IfcDerivedUnitEnum.PLANARFORCEUNIT                 | 
| IfcPlaneAngleMeasure                 | Angle                         | radian       | rad         | (0, 0, 0, 0, 0, 0, 0)   | IfcUnitEnum.PLANEANGLEUNIT                         | 
| IfcPowerMeasure                      | Power                         | watt         | W           | (2, 1, -3, 0, 0, 0, 0   | IfcUnitEnum.POWERUNIT                              | 
| IfcPressureMeasure                   | Pressure                      | pascal       | Pa          | (-1, 1, -2, 0, 0, 0, 0) | IfcUnitEnum.PRESSUREUNIT                           | 
| IfcRadioActivityMeasure              | Radio activity                | Becqurel     | Bq          | (0, 0, -1, 0, 0, 0, 0)  | IfcUnitEnum.RADIOACTIVITYUNIT                      | 
| IfcRatioMeasure                      | Ratio                         | Percent      | %           | (0, 0, 0, 0, 0, 0, 0)   |                                                    | 
| IfcRotationalFrequencyMeasure        | Rotational frequency          | hertz        | Hz          | (0, 0, -1, 0, 0, 0, 0)  | IfcDerivedUnitEnum.ROTATIONALFREQUENCYUNIT         | 
| IfcSectionModulusMeasure             | Section modulus               |              | m3          | (3, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.SECTIONMODULUSUNIT              | 
| IfcSoundPowerMeasure                 | Sound power                   | decibel      | db          | (0, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.SOUNDPOWERUNIT                  | 
| IfcSoundPressureMeasure              | Sound pressure                | decibel      | db          | (0, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.SOUNDPRESSUREUNIT               | 
| IfcSpecificHeatCapacityMeasure       | Specific heat capacity        |              | J/Kg K      | (2, 0, -2, 0, -1, 0, 0) | IfcDerivedUnitEnum.SPECIFICHEATCAPACITYUNIT        | 
| IfcTemperatureRateOfChangeMeasure    | Temperature rate of change    |              | K/s         | (0, 0, -1, 0, 1, 0, 0)  | IfcDerivedUnitEnum.TEMPERATURERATEOFCHANGEUNIT     | 
| IfcThermalConductivityMeasure        | Thermal conductivity          |              | W/m K       | (1, 1, -3, 0, -1, 0, 0) | IfcDerivedUnitEnum.THERMALCONDUCTANCEUNIT          | 
| IfcThermodynamicTemperatureMeasure   | Temperature                   | kelvin       | K           | (0, 0, 0, 0, 1, 0, 0)   | IfcUnitEnum.THERMODYNAMICTEMPERATUREUNIT           | 
| IfcTimeMeasure                       | Time                          | second       | s           | (0, 0, 1, 0, 0, 0, 0)   | IfcUnitEnum.TIMEUNIT                               | 
| IfcTorqueMeasure                     | Torque                        |              | N m         | (2, 1, -2, 0, 0, 0, 0)  | IfcDerivedUnitEnum.TORQUEUNIT                      | 
| IfcVaporPermeabilityMeasure          | Vapor permeability            |              | Kg / s m Pa | (0, 0, 1, 0, 0, 0, 0)   | IfcDerivedUnitEnum.VAPORPERMEABILITYUNIT           | 
| IfcVolumeMeasure                     | Volume                        | cubic meter  | m3          | (3, 0, 0, 0, 0, 0, 0)   | IfcUnitEnum.VOLUMEUNIT                             | 
| IfcVolumetricFlowRateMeasure         | Volumetric flow rate          |              | m3/s        | (3, 0, -1, 0, 0, 0, 0)  | IfcDerivedUnitEnum.VOLUMETRICFLOWRATEUNIT          | 

In software values are typically presented in local units. The following table lists some examples how things are represented to the user and how they are represented in IDS.

| User Perspective | IDS value | Physical Quantity |
|------------------|-----------|-------------------|
| 10 mm | 0.01| length |
| 1" | 0.0254 | length |
| 1 kW | 1000 | power |
| 1 lbs | 0.45359237 | mass |
| 20 C | 293.15 | temperature |
