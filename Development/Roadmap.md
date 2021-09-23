# Topics

The use-case analyses has provided insights in priorities for the implementation of the IDS.	

## Features for 0.1

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

## Features 0.2

 * Allowed values: XSD restrictions
 * Allowed Values: XSD Patterns
 
During the implementation of the first production release there will be a focus on consistency and reliability between tools.
Feedback will be used to fine-tune and tweak the XSD Schema and examples.

## In scope for 0.3 

 * Additional information about the IDS (Name, Author, copyright, license, description, etc)
 * Self defined object types (sometimes called 'classifications', or 'information unit', or something else) and mapping to IFC entities
 * Mandatory versus optional fields (all fields in the IDS need to be supported by implementations; when fields in an IDS are optional, this means the user does not require the data, but when the field is in the IFC it needs to adhere to the stated requirements)
 
## in scope for 0.4
 
 * finetuning correct use of XS:Restrictions or simple values
 * Adding label to allowed values 
 * IFC Attributes
 * Neccesity of objects in an IFC file (do objects need to be in the file, or is the requirement only in case the objects are found?).
 * Tweaking names of attributes

During the implementation of the second production release there will be a focus on consistency and reliability between tools.
Feedback will be used to fine-tune and tweak the XSD Schema and examples.

## Collaborative effort with vendors (Phase 2 of the IDS project)

When vendors have implemented the third production release in a consistent way, the next batch of features will be added:

 * Units (probably not IFC DataTypes; to be decided)
 * Implementer agreements
 * More examples
 
# Roadmap possible future versions

 * Defining structure of objects (Decomposition of objects) using bSDD
 * Adding additonal logic (OR)

When features are declared out of scope for the first final version, they will be put on the backlog.

Other features that have been mentioned in the IDS project, but have not been seen in actual use-cases could also be placed on the backlog.
