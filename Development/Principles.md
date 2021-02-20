
The project has analysed multiple use-cases that are defined in practise.
Elaboration on the use-cases during meetings has defined a couple of base principles for the IDS solution.

# Scope
This project is creating a 'language' to define 'Information Delivery Specifications'. There are many examples of IDSs in practise. These will be used to guide scope and focus.
This project explicitly does not want to create a language for design- or requirements validation. e-Permit examples like 'rooms above 3m should contain fire detectors within 1m of the door’ are out of scope. In scope are requirements like 'we need rooms' and 'fire detectors need to be delivered as IfcSensor, with predefined type x, and Pset_SensorTypeSmokeSensor'. Design validation rules are a differen topic from information delivery specifications. 

# Principles
The following guiding principles have been agreed on during the use-case analysis phase:
 * Decision of what is in scope and out of scope is Use-case driven.
 * Selection (sometimes called 'applicability') of objects should be seperate from the allocation of requirements to those objects.
 * XML seems the best choice as a technology for a first version.
 * Although there is a desire to reuse existing technologies (RuleML, Schematron, etc) vendors have declared they will not use toolkits and implement themselves. 
 * The IDS defines requirements for IFC based data exchanges. Other data standards are out of scope.
 * It is a desire to create an IDS language/schema that can be used independent of the IFC versions. Actual IDS files (use-cases) will/might still be specific for IFC versions.
 * Strict seperation between instance and type objects.
 * Translations are out of scope to store in one IDS file. A user can create different IDS files with different languages, or refer to translations in a seperate source (URI).
 * All fields in the standards need to be supported by implementations. When fields in an IDS are optional, this means the user does not require the data, but the software tool still needs to support the field.
 * 

 