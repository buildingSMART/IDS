# Information Delivery Specification

![IDS Logo](ids-logo.png)

**Information Delivery Specification (IDS)** is a buildingSMART standard for specifying and checking simple information requirements from IFC models. It is designed as a free, lightweight, standardised approach to model checking.

## Introduction

An IDS is a file format ending in `.ids` containing a list of information **Specifications**. For example, a single **Specification** might say that "_all walls must have a fire rating property_". Model authors receiving an IDS file can use it to ensure all required information is provided for each **Specification**. Model recipients may use the IDS file to check whether the IFC model meets all of the **Specifications**. Reports may also be generated to list the results of **Specification** compliance checks.

![IDS Diagram](ids-diagram.png)

IDS file creation tools and model checking tools are provided by many [software vendors](https://technical.buildingsmart.org/resources/software-implementations/). You can write your own customised IDS **Specifications** from scratch or start from a [public IDS template](todo). Any IFC model produced from any software can be checked by an IDS file.

## Beginners tutorial

 1. [Download and install your favourite software](https://technical.buildingsmart.org/resources/software-implementations/) that supports IDS from the software vendors directory. There is software available for Windows, Mac, and Linux.
 2. [Download a sample IDS file](library/sample.ids). This IDS file has two **Specifications**. The first specifies that _the project name should be TEST_. The second specifies that _all walls must have a fire rating property_.
 3. [Download a sample IFC model to check](library/sample.ifc). This IFC model has "TEST" as the project name, which satisfies the first **Specification**. However, some walls have a fire rating property, and others do not.
 4. Load both the IDS and the IFC in your software, and begin the checking process.

That's it! You may also find more sample IDS templates in the [buildingSMART IDS Template Directory](https://github.com/buildingSMART/IDS/tree/master/Development) and more sample IFC models in the [buildingSMART IFC model directory](https://github.com/buildingSMART/Sample-Test-Files).

If you need help, please feel free to ask for help on the [buildingSMART Forums](https://forums.buildingsmart.org/).

## Begin learning about IDS

 1. [How does a **Specification** work?](specifications.md)
 1. [Guidelines on specifying good **Specification** metadata](ids-metadata.md)
 1. [Learn how to specify **Complex Restrictions**](restrictions.md)
 1. [Learn how to use the **Entity Facet**](entity-facet.md)
 1. [Learn how to use the **Attribute Facet**](attribute-facet.md)
 1. [Learn how to use the **Classification Facet**](classification-facet.md)
 1. [Learn how to use the **Property Facet**](property-facet.md)
 1. [Learn how to use the **Material Facet**](material-facet.md)
 1. [Learn how to use the **PartOf Facet**](partof-facet.md)
 1. [Are you a software developer? Read the developer guide!](developer-guide.md)
