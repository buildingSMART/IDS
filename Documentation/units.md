# Units in IDS

Numerical measure values are represented in IDS files using SI units.

When IFC models are verified, their values need to be converted to the default unit before comparison.

The following table lists the measures that need to be converted, along with the metadata to support the conversion process.
A full list of IFC Defined types can be found in the IFC documentation.

The order of dimensional exponent units is `(m, Kg, s, A, K, mol, cd)`.

| Ifc Defined Type name                         | Physical Quantity description           | Unit         | Unit Symbol | Dimensional exponents   | Unit enumeration                                           |
| --------------------------------------------- | --------------------------------------- | ------------ | ----------- | ----------------------- | ---------------------------------------------------------- |
| IFCABSORBEDDOSEMEASURE                        | Absorbed radioactivity dose             | Gray         | J/Kg        | (2, 0, -2, 0, 0, 0, 0)  | IfcUnitEnum.ABSORBEDDOSEUNIT                               |
| IFCACCELERATIONMEASURE                        | Acceleration                            |              | m / s2      | (1, 0, -2, 0, 0, 0, 0)  | IfcDerivedUnitEnum.ACCELERATIONUNIT                        |
| IFCAMOUNTOFSUBSTANCEMEASURE                   | Amount of substance                     | mole         | mol         | (0, 0, 0, 0, 0, 1, 0)   | IfcUnitEnum.AMOUNTOFSUBSTANCEUNIT                          |
| IFCANGULARVELOCITYMEASURE                     | Angular velocity                        |              | rad / s     | (0, 0, -1, 0, 0, 0, 0)  | IfcDerivedUnitEnum.ANGULARVELOCITYUNIT                     |
| IFCAREADENSITYMEASURE                         | Area density                            |              | Kg/m2       | (-2, 1, 0, 0, 0, 0, 0)  | IfcDerivedUnitEnum.AREADENSITYUNIT                         |
| IFCAREAMEASURE                                | Area                                    | square meter | m2          | (2, 0, 0, 0, 0, 0, 0)   | IfcUnitEnum.AREAUNIT                                       |
| IFCCONTEXTDEPENDENTMEASURE                    |                                         |              |             |                         |                                                            |
| IFCCOUNTMEASURE                               |                                         |              |             |                         |                                                            |
| IFCCURVATUREMEASURE                           | Curvature                               |              | rad / m     | (-1, 0, 0, 0, 0, 0, 0)  | IfcDerivedUnitEnum.CURVATUREUNIT                           |
| IFCDESCRIPTIVEMEASURE                         |                                         |              |             |                         |                                                            |
| IFCDOSEEQUIVALENTMEASURE                      | Dose equivalent                         | Sievert      | J / Kg      | (2, 0, -2, 0, 0, 0, 0)  | IfcUnitEnum.DOSEEQUIVALENTUNIT                             |
| IFCDYNAMICVISCOSITYMEASURE                    | Dynamic viscosity                       |              | Pa s        | (-1, 1, -1, 0, 0, 0, 0) | IfcDerivedUnitEnum.DYNAMICVISCOSITYUNIT                    |
| IFCELECTRICCAPACITANCEMEASURE                 | Electric capacitance                    | farad        | F           | (-2, 1, 4, 1, 0, 0, 0)  | IfcUnitEnum.ELECTRICCAPACITANCEUNIT                        |
| IFCELECTRICCHARGEMEASURE                      | Electric charge                         | coulomb      | C           | (0, 0, 1, 1, 0, 0, 0)   | IfcUnitEnum.ELECTRICCHARGEUNIT                             |
| IFCELECTRICCONDUCTANCEMEASURE                 | Electric conductance                    | siemens      | S           | (-2, -1, 3, 2, 0, 0, 0) | IfcUnitEnum.ELECTRICCONDUCTANCEUNIT                        |
| IFCELECTRICCURRENTMEASURE                     | Electric current                        | ampere       | A           | (0, 0, 0, 1, 0, 0, 0)   | IfcUnitEnum.ELECTRICCURRENTUNIT                            |
| IFCELECTRICRESISTANCEMEASURE                  | Electric resistance                     | ohm          | Ω           | (2, 1, -3, -2, 0, 0, 0) | IfcUnitEnum.ELECTRICRESISTANCEUNIT                         |
| IFCELECTRICVOLTAGEMEASURE                     | Electric voltage                        | volt         | V           | (2, 1, -3, -1, 0, 0, 0) | IfcUnitEnum.ELECTRICVOLTAGEUNIT                            |
| IFCENERGYMEASURE                              | Energy                                  | joule        | J           | (2, 1, -2, 0, 0, 0, 0)  | IfcUnitEnum.ENERGYUNIT                                     |
| IFCFORCEMEASURE                               | Force                                   | newton       | N           | (1, 1, -2, 0, 0, 0, 0)  | IfcUnitEnum.FORCEUNIT                                      |
| IFCFREQUENCYMEASURE                           | Frequency                               | hertz        | Hz          | (0, 0, -1, 0, 0, 0, 0)  | IfcUnitEnum.FREQUENCYUNIT                                  |
| IFCHEATFLUXDENSITYMEASURE                     | Heat flux density                       |              | W/m2        | (0, 1, -3, 0, 0, 0, 0)  | IfcDerivedUnitEnum.HEATFLUXDENSITYUNIT                     |
| IFCHEATINGVALUEMEASURE                        | Heating                                 |              | J/K         | (2, 1, -2, 0, -1, 0, 0) | IfcDerivedUnitEnum.HEATINGVALUEUNIT                        |
| IFCILLUMINANCEMEASURE                         | Illuminance                             | lux          | lx          | (-2, 0, 0, 0, 0, 0, 1)  | IfcUnitEnum.ILLUMINANCEUNIT                                |
| IFCINDUCTANCEMEASURE                          | Inductance                              | henry        | Wb / A      | (2, 1, -2, -2, 0, 0, 0) | IfcUnitEnum.INDUCTANCEUNIT                                 |
| IFCINTEGERCOUNTRATEMEASURE                    | Count rate                              |              | 1 / s       | (0, 0, -1, 0, 0, 0, 0)  | IfcDerivedUnitEnum.INTEGERCOUNTRATEUNIT                    |
| IFCIONCONCENTRATIONMEASURE                    | Ion concentration measure               |              | mol/m3      | (-3, 1, 0, 0, 0, 0, 0)  | IfcDerivedUnitEnum.IONCONCENTRATIONUNIT                    |
| IFCISOTHERMALMOISTURECAPACITYMEASURE          | Iso thermal moisture capacity           |              | m3/Kg       | (3, -1, 0, 0, 0, 0, 0)  | IfcDerivedUnitEnum.ISOTHERMALMOISTURECAPACITYUNIT          |
| IFCKINEMATICVISCOSITYMEASURE                  | Kinematic viscosity                     |              | m2 / s      | (2, 0, -1, 0, 0, 0, 0)  | IfcDerivedUnitEnum.KINEMATICVISCOSITYUNIT                  |
| IFCLENGTHMEASURE                              | Length                                  | meter        | m           | (1, 0, 0, 0, 0, 0, 0)   | IfcUnitEnum.LENGTHUNIT                                     |
| IFCLINEARFORCEMEASURE                         | Linear force                            |              | N / m       | (0, 1, -2, 0, 0, 0, 0)  | IfcDerivedUnitEnum.LINEARFORCEUNIT                         |
| IFCLINEARMOMENTMEASURE                        | Linear moment                           |              | N m / m     | (1, 1, -2, 0, 0, 0, 0)  | IfcDerivedUnitEnum.LINEARMOMENTUNIT                        |
| IFCLINEARSTIFFNESSMEASURE                     | Linear stiffness                        |              | N / m       | (0, 1, -2, 0, 0, 0, 0)  | IfcDerivedUnitEnum.LINEARSTIFFNESSUNIT                     |
| IFCLINEARVELOCITYMEASURE                      | Speed                                   |              | m/s         | (1, 0, -1, 0, 0, 0, 0)  | IfcDerivedUnitEnum.LINEARVELOCITYUNIT                      |
| IFCLUMINOUSFLUXMEASURE                        | Luminous flux                           | Lumen        | lm          | (0, 0, 0, 0, 0, 0, 1)   | IfcUnitEnum.LUMINOUSFLUXUNIT                               |
| IFCLUMINOUSINTENSITYDISTRIBUTIONMEASURE       | Luminous intensity distribution         |              | cd / lm     | (0, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.LUMINOUSINTENSITYDISTRIBUTIONUNIT       |
| IFCLUMINOUSINTENSITYMEASURE                   | Luminous intensity                      | candela      | cd          | (0, 0, 0, 0, 0, 0, 1)   | IfcUnitEnum.LUMINOUSINTENSITYUNIT                          |
| IFCMAGNETICFLUXDENSITYMEASURE                 | Magnetic flux density                   | tesla        | Wb / m2     | (0, 1, -2, -1, 0, 0, 0) | IfcUnitEnum.MAGNETICFLUXDENSITYUNIT                        |
| IFCMAGNETICFLUXMEASURE                        | Magnetic flux                           | weber        | Wb          | (2, 1, -2, -1, 0, 0, 0) | IfcDerivedUnitEnum.MAGNETICFLUXUNIT                        |
| IFCMASSDENSITYMEASURE                         | Mass density                            |              | Kg/m3       | (-3, 1, 0, 0, 0, 0, 0)  | IfcDerivedUnitEnum.MASSDENSITYUNIT                         |
| IFCMASSFLOWRATEMEASURE                        | Mass flow rate                          |              | Kg/s        | (0, 1, -1, 0, 0, 0, 0)  | IfcDerivedUnitEnum.MASSFLOWRATEUNIT                        |
| IFCMASSMEASURE                                | Mass                                    | kilogram     | Kg          | (0, 1, 0, 0, 0, 0, 0)   | IfcUnitEnum.MASSUNIT                                       |
| IFCMASSPERLENGTHMEASURE                       | Mass per length                         |              | Kg/m        | (-1, 1, 0, 0, 0, 0, 0)  | IfcDerivedUnitEnum.MASSPERLENGTHUNIT                       |
| IFCMODULUSOFELASTICITYMEASURE                 | Modulus of elasticity                   |              | N/m2        | (-1, 1, -2, 0, 0, 0, 0) | IfcDerivedUnitEnum.MODULUSOFELASTICITYUNIT                 |
| IFCMODULUSOFLINEARSUBGRADEREACTIONMEASURE     | Modulus of linear subgrade reaction     |              | N / m2      | (-1, 1, -2, 0, 0, 0, 0) | IfcDerivedUnitEnum.MODULUSOFLINEARSUBGRADEREACTIONUNIT     |
| IFCMODULUSOFROTATIONALSUBGRADEREACTIONMEASURE | Modulus of rotational subgrade reaction |              | N m / m rad | (1, 1, -2, 0, 0, 0, 0)  | IfcDerivedUnitEnum.MODULUSOFROTATIONALSUBGRADEREACTIONUNIT |
| IFCMODULUSOFSUBGRADEREACTIONMEASURE           | Modulus of subgrade reaction            |              | N / m3      | (-2, 1, -2, 0, 0, 0, 0) | IfcDerivedUnitEnum.MODULUSOFSUBGRADEREACTIONUNIT           |
| IFCMOISTUREDIFFUSIVITYMEASURE                 | Moisture diffusivity                    |              | m3/s        | (3, 0, -1, 0, 0, 0, 0)  | IfcDerivedUnitEnum.MOISTUREDIFFUSIVITYUNIT                 |
| IFCMOLECULARWEIGHTMEASURE                     | Molecular weight                        |              | Kg/mol      | (0, 1, 0, 0, 0, -1, 0)  | IfcDerivedUnitEnum.MOLECULARWEIGHTUNIT                     |
| IFCMOMENTOFINERTIAMEASURE                     | Moment of inertia                       |              | m4          | (4, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.MOMENTOFINERTIAUNIT                     |
| IFCMONETARYMEASURE                            |                                         |              |             |                         |                                                            |
| IFCNONNEGATIVELENGTHMEASURE                   | Non negative length                     | meter        | m           | (1, 0, 0, 0, 0, 0, 0)   | IfcUnitEnum.LENGTHUNIT                                     |
| IFCNORMALISEDRATIOMEASURE                     |                                         |              |             |                         |                                                            |
| IFCNUMERICMEASURE                             |                                         |              |             |                         |                                                            |
| IFCPHMEASURE                                  | PH                                      |              | PH          | (0, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.PHUNIT                                  |
| IFCPLANARFORCEMEASURE                         | Planar force                            |              | Pa          | (-1, 1, -2, 0, 0, 0, 0) | IfcDerivedUnitEnum.PLANARFORCEUNIT                         |
| IFCPLANEANGLEMEASURE                          | Angle                                   | radian       | rad         | (0, 0, 0, 0, 0, 0, 0)   | IfcUnitEnum.PLANEANGLEUNIT                                 |
| IFCPOSITIVELENGTHMEASURE                      | Positive length                         | meter        | m           | (1, 0, 0, 0, 0, 0, 0)   | IfcUnitEnum.LENGTHUNIT                                     |
| IFCPOSITIVEPLANEANGLEMEASURE                  | Positive plane angle                    | radian       | rad         | (0, 0, 0, 0, 0, 0, 0)   | IfcUnitEnum.PLANEANGLEUNIT                                 |
| IFCPOSITIVERATIOMEASURE                       |                                         |              |             |                         |                                                            |
| IFCPOWERMEASURE                               | Power                                   | watt         | W           | (2, 1, -3, 0, 0, 0, 0)  | IfcUnitEnum.POWERUNIT                                      |
| IFCPRESSUREMEASURE                            | Pressure                                | pascal       | Pa          | (-1, 1, -2, 0, 0, 0, 0) | IfcUnitEnum.PRESSUREUNIT                                   |
| IFCRADIOACTIVITYMEASURE                       | Radio activity                          | Becqurel     | Bq          | (0, 0, -1, 0, 0, 0, 0)  | IfcUnitEnum.RADIOACTIVITYUNIT                              |
| IFCRATIOMEASURE                               | Ratio                                   |              |             | (0, 0, 0, 0, 0, 0, 0)   |                                                            |
| IFCROTATIONALFREQUENCYMEASURE                 | Rotational frequency                    | hertz        | Hz          | (0, 0, -1, 0, 0, 0, 0)  | IfcDerivedUnitEnum.ROTATIONALFREQUENCYUNIT                 |
| IFCROTATIONALMASSMEASURE                      | Rotational mass                         |              | Kg m2       | (2, 1, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.ROTATIONALMASSUNIT                      |
| IFCROTATIONALSTIFFNESSMEASURE                 | Rotational stiffness                    |              | N m / rad   | (2, 1, -2, 0, 0, 0, 0)  | IfcDerivedUnitEnum.ROTATIONALSTIFFNESSUNIT                 |
| IFCSECTIONALAREAINTEGRALMEASURE               | Sectional area integral                 |              | m5          | (5, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.SECTIONALAREAINTEGRALUNIT               |
| IFCSECTIONMODULUSMEASURE                      | Section modulus                         |              | m3          | (3, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.SECTIONMODULUSUNIT                      |
| IFCSHEARMODULUSMEASURE                        | Shear modulus                           |              | N / m2      | (-1, 1, -2, 0, 0, 0, 0) | IfcDerivedUnitEnum.SHEARMODULUSUNIT                        |
| IFCSOLIDANGLEMEASURE                          | Solid angle                             | steradin     | sr          | (0, 0, 0, 0, 0, 0, 0)   | IfcUnitEnum.SOLIDANGLEUNIT                                 |
| IFCSOUNDPOWERLEVELMEASURE                     | Sound power level                       | decibel      | db          | (0, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.SOUNDPOWERLEVELUNIT                     |
| IFCSOUNDPOWERMEASURE                          | Sound power                             | decibel      | db          | (0, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.SOUNDPOWERUNIT                          |
| IFCSOUNDPRESSURELEVELMEASURE                  | Sound pressure level                    | decibel      | db          | (0, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.SOUNDPRESSURELEVELUNIT                  |
| IFCSOUNDPRESSUREMEASURE                       | Sound pressure                          | decibel      | db          | (0, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.SOUNDPRESSUREUNIT                       |
| IFCSPECIFICHEATCAPACITYMEASURE                | Specific heat capacity                  |              | J/Kg K      | (2, 0, -2, 0, -1, 0, 0) | IfcDerivedUnitEnum.SPECIFICHEATCAPACITYUNIT                |
| IFCTEMPERATUREGRADIENTMEASURE                 | Temperature gradient                    |              | K/m         | (-1, 0, 0, 0, 1, 0, 0)  | IfcDerivedUnitEnum.TEMPERATUREGRADIENTUNIT                 |
| IFCTEMPERATURERATEOFCHANGEMEASURE             | Temperature rate of change              |              | K/s         | (0, 0, -1, 0, 1, 0, 0)  | IfcDerivedUnitEnum.TEMPERATURERATEOFCHANGEUNIT             |
| IFCTHERMALADMITTANCEMEASURE                   | Thermal admittance                      |              | W / m2 K    | (0, 1, -3, 0, -1, 0, 0) | IfcDerivedUnitEnum.THERMALADMITTANCEUNIT                   |
| IFCTHERMALCONDUCTIVITYMEASURE                 | Thermal conductivity                    |              | W/m K       | (1, 1, -3, 0, -1, 0, 0) | IfcDerivedUnitEnum.THERMALCONDUCTANCEUNIT                  |
| IFCTHERMALEXPANSIONCOEFFICIENTMEASURE         | Thermal expansion coefficient           |              | 1 / K       | (0, 0, 0, 0, -1, 0, 0)  | IfcDerivedUnitEnum.THERMALEXPANSIONCOEFFICIENTUNIT         |
| IFCTHERMALRESISTANCEMEASURE                   | Thermal resistance                      |              | m2  K / W   | (0, -1, 3, 0, 1, 0, 0)  | IfcDerivedUnitEnum.THERMALRESISTANCEUNIT                   |
| IFCTHERMALTRANSMITTANCEMEASURE                | Thermal transmittance                   |              | W / m2 K    | (0, 1, -3, 0, -1, 0, 0) | IfcDerivedUnitEnum.THERMALTRANSMITTANCEUNIT                |
| IFCTHERMODYNAMICTEMPERATUREMEASURE            | Temperature                             | kelvin       | K           | (0, 0, 0, 0, 1, 0, 0)   | IfcUnitEnum.THERMODYNAMICTEMPERATUREUNIT                   |
| IFCTIMEMEASURE                                | Time                                    | second       | s           | (0, 0, 1, 0, 0, 0, 0)   | IfcUnitEnum.TIMEUNIT                                       |
| IFCTORQUEMEASURE                              | Torque                                  |              | N m         | (2, 1, -2, 0, 0, 0, 0)  | IfcDerivedUnitEnum.TORQUEUNIT                              |
| IFCVAPORPERMEABILITYMEASURE                   | Vapor permeability                      |              | Kg / s m Pa | (0, 0, 1, 0, 0, 0, 0)   | IfcDerivedUnitEnum.VAPORPERMEABILITYUNIT                   |
| IFCVOLUMEMEASURE                              | Volume                                  | cubic meter  | m3          | (3, 0, 0, 0, 0, 0, 0)   | IfcUnitEnum.VOLUMEUNIT                                     |
| IFCVOLUMETRICFLOWRATEMEASURE                  | Volumetric flow rate                    |              | m3/s        | (3, 0, -1, 0, 0, 0, 0)  | IfcDerivedUnitEnum.VOLUMETRICFLOWRATEUNIT                  |
| IFCWARPINGCONSTANTMEASURE                     | Warping constant                        |              | m6          | (6, 0, 0, 0, 0, 0, 0)   | IfcDerivedUnitEnum.WARPINGCONSTANTUNIT                     |
| IFCWARPINGMOMENTMEASURE                       | Warping moment                          |              | N m2        | (3, 1, -2, 0, 0, 0, 0)  | IfcDerivedUnitEnum.WARPINGMOMENTUNIT                       |

## Dimensional units

Each of the dimensional exponents references the default SI unit

| Position in the dimensional exponents list | Physical Quantity | SI Unit                   |
| ------------------------------------------ | ----------------- | ------------------------- |
| 1                                          | length            | metre                     |
| 2                                          | mass              | kilogram                  |
| 3                                          | time              | second                    |
| 4                                          | ampere            | electric current          |
| 5                                          | kelvin            | thermodynamic temperature |
| 6                                          | mole              | amount of substance       |
| 7                                          | candela           | luminous intensity        |

## Examples

In software values are typically presented in local units. The following table lists some examples how things are represented to the user and how they are represented in IDS.

| User Perspective | IDS value  | Physical Quantity |
| ---------------- | ---------- | ----------------- |
| 10 mm            | 0.01       | length            |
| 1"               | 0.0254     | length            |
| 1 kW             | 1000       | power             |
| 1 lbs            | 0.45359237 | mass              |
| 20 C             | 293.15     | temperature       |
