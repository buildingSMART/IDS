# Topics

The use-case analyses has provided insights in priorities for the implementation of the IDS.	

## Features for first production version

 * Selection and requirements seperatly defined
 * IFC Entities
 * IFC Predefined Types (1)
 * IFC Classification References (1)
 * IFC Properties and Quanities (1)
 * Self defined Properties (1)
 * IFC Property set names (1)
 * Allowed values: Enumerations
 * References to external sources (URI, bSDD)
 * IFC Material (1)

(1) = this requires a definition of an 'ifc Lite' structure as well.
During the implementation of the first production release there will be a focus on consistency and reliability between tools.
Feedback will be used to fine-tune and tweak the XSD Schema and examples.

## Features second production version

When vendors have implemented the first production release in a consistent way, the next batch of features will be added:
 * Allowed values: Adding label to allowed values 
 * Allowed values: XML restrictions
 * Allowed Values: XML Patterns and/or Regular Expressions
 
During the implementation of the first production release there will be a focus on consistency and reliability between tools.
Feedback will be used to fine-tune and tweak the XSD Schema and examples.

## In scope for third production version 

 * Logic in selection: AND and OR
 * Self defined object types (sometimes called 'classifications', or 'information unit', or something else) and mapping to IFC entities
 * Units (probably not IFC DataTypes; to be decided)
 * Mandatory versus optional fields (all fields in the IDS need to be supported by implementations; when fields in an IDS are optional, this means the user does not require the data, but when the field is in the IFC it needs to adhere to the stated requirements)


During the implementation of the second production release there will be a focus on consistency and reliability between tools.
Feedback will be used to fine-tune and tweak the XSD Schema and examples.

## Fine tuning production version

When vendors have implemented the third production release in a consistent way, the next batch of features will be added:

 * Additional information about the IDS (Name, Author, copyright, license, description, etc)
 * Logic in requirements: OR (AND is by definition of mandatory/optional)
 * Defining structure of objects (Decomposition of objects)
 * IFC Attributes
 
Some of the features mentioned in this phase, might be declared out of scope for the first final version of IDS. This is depending on the implementability and priority of the use-cases.

# Roadmap future versions

When features are declared out of scope for the first final version, they will be put on the backlog.
Other features that come up during the 

Other features that have been mentioned in the IDS project, but have not been seen in actual use-cases could also be placed on the backlog.