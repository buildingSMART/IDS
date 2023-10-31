# Units in IDS

Numerical measure values are represented using SI units. The following table lists the physical quantities and their units.
A full list of IFC Defined types can be found in the IFC documentation.

| Ifc Defined Type name                | Physical Quantity description | Unit         | Unit Symbol | Dimensional exponents   | Unit enumeration                                  |
| ------------------------------------ | ----------------------------- | ------------ | ----------- | ----------------------- | ------------------------------------------------- |
| IFCAMOUNTOFSUBSTANCEMEASURE          | Amount of substance           | mole         | mol         | (0, 0, 0, 0, 0, 1, 0)   | IfcUnitEnum.AMOUNTOFSUBSTANCEUNIT                 |
| IFCAREADENSITYMEASURE                | Area density                  |              | Kg/m2       | (-2, 1, 0, 0, 0, 0, 0)  | IfcDerivedUnitEnum.AREADENSITYUNIT                |
| IFCAREAMEASURE                       | Area                          | square meter | m2          | (2, 0, 0, 0, 0, 0, 0)   | IfcUnitEnum.AREAUNIT                              |
| IFCDYNAMICVISCOSITYMEASURE           | Dynamic viscosity             |              | Pa s        | (-1, 1, -1, 0, 0, 0, 0) | IfcDerivedUnitEnum.DYNAMICVISCOSITYUNIT           |
| IFCELECTRICCAPACITANCEMEASURE        | Electric capacitance          | farad        | F           | (-2, 1, 4, 1, 0, 0, 0)  | IfcUnitEnum.ELECTRICCAPACITANCEUNIT               |
| IFCELECTRICCHARGEMEASURE             | Electric charge               | coulomb      | C           | (0, 0, 1, 1, 0, 0, 0)   | IfcUnitEnum.ELECTRICCHARGEUNIT                    |
| IFCELECTRICCONDUCTANCEMEASURE        | Electric conductance          | siemens      | S           | (-2, -1, 3, 2, 0, 0, 0) | IfcUnitEnum.ELECTRICCONDUCTANCEUNIT               |
| IFCELECTRICCURRENTMEASURE            | Electric current              | ampere       | A           | (0, 0, 0, 1, 0, 0, 0)   | IfcUnitEnum.ELECTRICCURRENTUNIT                   |
| IFCELECTRICRESISTANCEMEASURE         | Electric resistance           | ohm          | Ω           | (2, 1, -3, -2, 0, 0, 0) | IfcUnitEnum.ELECTRICRESISTANCEUNIT                |
| IFCELECTRICVOLTAGEMEASURE            | Electric voltage              | volt         | V           | (2, 1, -3, -1, 0, 0, 0) | IfcUnitEnum.ELECTRICVOLTAGEUNIT                   |
| IFCENERGYMEASURE                     | Energy                        | joule        | J           | (2, 1, -2, 0, 0, 0, 0)  | IfcUnitEnum.ENERGYUNIT                            |
| IFCFORCEMEASURE                      | Force                         | newton       | N           | (1, 1, -2, 0, 0, 0, 0)  | IfcUnitEnum.FORCEUNIT                             |
| IFCFREQUENCYMEASURE                  | Frequency                     | hertz        | Hz          | (0, 0, -1, 0, 0, 0, 0)  | IfcUnitEnum.FREQUENCYUNIT                         |
| IFCHEATFLUXDENSITYMEASURE            | Heat flux density             |              | W/m2        | (0, 1, -3, 0, 0, 0, 0)  | IfcDerivedUnitEnum.HEATFLUXDENSITYUNIT            |
| IFCHEATINGVALUEMEASURE               | Heating                       |              | J/K         | (2, 1, -2, 0, -1, 0, 0) | IfcDerivedUnitEnum.HEATINGVALUEUNIT               |
| IFCILLUMINANCEMEASURE                | Illuminance                   | lux          | lx          | (-2, 0, 0, 0, 0, 0, 1)  | IfcUnitEnum.ILLUMINANCEUNIT                       |
| IFCIONCONCENTRATIONMEASURE           | Ion concentration measure     |              | mol/m3      | (-3, 1, 0, 0, 0, 0, 0)  | IfcDerivedUnitEnum.IONCONCENTRATIONUNIT           |
| IFCISOTHERMALMOISTURECAPACITYMEASURE | Iso thermal moisture capacity |              | m3/Kg       | (3, -1, 0, 0, 0, 0, 0)  | IfcDerivedUnitEnum.ISOTHERMALMOISTURECAPACITYUNIT |
| IFCLENGTHMEASURE                     | Length                        | meter        | m           | (1, 0, 0, 0, 0, 0, 0)   | IfcUnitEnum.LENGTHUNIT                            |
| IFCLINEARVELOCITYMEASURE             | Speed                         |              | m/s         | (1, 0, -1, 0, 0, 0, 0)  | IfcDerivedUnitEnum.LINEARVELOCITYUNIT             |
| IFCLUMINOUSFLUXMEASURE               | Luminous flux                 | Lumen        | lm          | (0, 0, 0, 0, 0, 0, 1)   | IfcUnitEnum.LUMINOUSFLUXUNIT                      |
| IFCLUMINOUSINTENSITYMEASURE          | Luminous intensity            | candela      | cd          | (0, 0, 0, 0, 0, 0, 1)   | IfcUnitEnum.LUMINOUSINTENSITYUNIT                 |
| IFCMASSDENSITYMEASURE                | Mass density                  |              | Kg/m3       | (-3, 1, 0, 0, 0, 0, 0)  | IfcDerivedUnitEnum.MASSDENSITYUNIT                |
| IFCMASSFLOWRATEMEASURE               | Mass flow rate                |              | Kg/s        | (0, 1, -1, 0, 0, 0, 0)  | IfcDerivedUnitEnum.MASSFLOWRATEUNIT               |
| IFCMASSMEASURE                       | Mass                          | kilogram     | Kg          | (0, 1, 0, 0, 0, 0, 0)   | IfcUnitEnum.MASSUNIT                              |
| IFCMASSPERLENGTHMEASURE              | Mass per length               |              | Kg/m        | (-1, 1, 0, 0, 0, 0, 0)  | IfcDerivedUnitEnum.MASSPERLENGTHUNIT              |
| IFCMODULUSOFELASTICITYMEASURE        | Modulus of elasticity         |              | N/m2        | (-1, 1, -2, 0, 0, 0, 0) | IfcDerivedUnitEnum.MODULUSOFELASTICITYUNIT        |
| IFCMOISTUREDIFFUSIVITYMEASURE        | Moisture diffusivity          |              | m3/s        | (3, 0, -1, 0, 0, 0, 0)  | IfcDerivedUnitEnum.MOISTUREDIFFUSIVITYUNIT        |
| IFCMOLECULARWEIGHTMEASURE            | Molecular weight              |              | Kg/mol      | (0, 1, 0, 0, 0, -1, 0)  | IfcDerivedUnitEnum.MOLECULARWEIGHTUNIT            |
| IFCMOMENTOFINERTIAMEASURE            | Moment of inertia             |              | m4          | (4, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.MOMENTOFINERTIAUNIT            |
| IFCPHMEASURE                         | PH                            |              | PH          | (0, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.PHUNIT                         |
| IFCPLANARFORCEMEASURE                | Planar force                  |              | Pa          | (-1, 1, -2, 0, 0, 0, 0) | IfcDerivedUnitEnum.PLANARFORCEUNIT                |
| IFCPLANEANGLEMEASURE                 | Angle                         | radian       | rad         | (0, 0, 0, 0, 0, 0, 0)   | IfcUnitEnum.PLANEANGLEUNIT                        |
| IFCPOWERMEASURE                      | Power                         | watt         | W           | (2, 1, -3, 0, 0, 0, 0   | IfcUnitEnum.POWERUNIT                             |
| IFCPRESSUREMEASURE                   | Pressure                      | pascal       | Pa          | (-1, 1, -2, 0, 0, 0, 0) | IfcUnitEnum.PRESSUREUNIT                          |
| IFCRADIOACTIVITYMEASURE              | Radio activity                | Becqurel     | Bq          | (0, 0, -1, 0, 0, 0, 0)  | IfcUnitEnum.RADIOACTIVITYUNIT                     |
| IFCRATIOMEASURE                      | Ratio                         | Percent      | %           | (0, 0, 0, 0, 0, 0, 0)   |                                                   |
| IFCROTATIONALFREQUENCYMEASURE        | Rotational frequency          | hertz        | Hz          | (0, 0, -1, 0, 0, 0, 0)  | IfcDerivedUnitEnum.ROTATIONALFREQUENCYUNIT        |
| IFCSECTIONMODULUSMEASURE             | Section modulus               |              | m3          | (3, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.SECTIONMODULUSUNIT             |
| IFCSOUNDPOWERMEASURE                 | Sound power                   | decibel      | db          | (0, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.SOUNDPOWERUNIT                 |
| IFCSOUNDPRESSUREMEASURE              | Sound pressure                | decibel      | db          | (0, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.SOUNDPRESSUREUNIT              |
| IFCSPECIFICHEATCAPACITYMEASURE       | Specific heat capacity        |              | J/Kg K      | (2, 0, -2, 0, -1, 0, 0) | IfcDerivedUnitEnum.SPECIFICHEATCAPACITYUNIT       |
| IFCTEMPERATURERATEOFCHANGEMEASURE    | Temperature rate of change    |              | K/s         | (0, 0, -1, 0, 1, 0, 0)  | IfcDerivedUnitEnum.TEMPERATURERATEOFCHANGEUNIT    |
| IFCTHERMALCONDUCTIVITYMEASURE        | Thermal conductivity          |              | W/m K       | (1, 1, -3, 0, -1, 0, 0) | IfcDerivedUnitEnum.THERMALCONDUCTANCEUNIT         |
| IFCTHERMODYNAMICTEMPERATUREMEASURE   | Temperature                   | kelvin       | K           | (0, 0, 0, 0, 1, 0, 0)   | IfcUnitEnum.THERMODYNAMICTEMPERATUREUNIT          |
| IFCTIMEMEASURE                       | Time                          | second       | s           | (0, 0, 1, 0, 0, 0, 0)   | IfcUnitEnum.TIMEUNIT                              |
| IFCTORQUEMEASURE                     | Torque                        |              | N m         | (2, 1, -2, 0, 0, 0, 0)  | IfcDerivedUnitEnum.TORQUEUNIT                     |
| IFCVAPORPERMEABILITYMEASURE          | Vapor permeability            |              | Kg / s m Pa | (0, 0, 1, 0, 0, 0, 0)   | IfcDerivedUnitEnum.VAPORPERMEABILITYUNIT          |
| IFCVOLUMEMEASURE                     | Volume                        | cubic meter  | m3          | (3, 0, 0, 0, 0, 0, 0)   | IfcUnitEnum.VOLUMEUNIT                            |
| IFCVOLUMETRICFLOWRATEMEASURE         | Volumetric flow rate          |              | m3/s        | (3, 0, -1, 0, 0, 0, 0)  | IfcDerivedUnitEnum.VOLUMETRICFLOWRATEUNIT         |

In software values are typically presented in local units. The following table lists some examples how things are represented to the user and how they are represented in IDS.

| User Perspective | IDS value  | Physical Quantity |
| ---------------- | ---------- | ----------------- |
| 10 mm            | 0.01       | length            |
| 1"               | 0.0254     | length            |
| 1 kW             | 1000       | power             |
| 1 lbs            | 0.45359237 | mass              |
| 20 C             | 293.15     | temperature       |
