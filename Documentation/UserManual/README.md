# Information Delivery Specification

<img src="Graphics/IDS-logo-with-letters.png" alt="IDS Logo" width="300"/>

**Information Delivery Specification (IDS)** is a buildingSMART standard for specifying and checking simple information requirements from IFC models. It is designed as a free, lightweight, standardised approach to model checking. Read more on the [official website](https://www.buildingsmart.org/standards/bsi-standards/information-delivery-specification-ids/).

## Introduction

An IDS is a file format ending in `.ids` containing a list of information **Specifications**. For example, a single **Specification** might say that "_all walls must have a fire rating property_". Model authors receiving an IDS file can use it to ensure all required information is provided for each **Specification**. Model recipients may use the IDS file to check whether the IFC model meets all of the **Specifications**. Reports may also be generated to list the results of **Specification** compliance checks.

![IDS Diagram](Graphics/ids-diagram.png)

IDS file creation tools and model checking tools are provided by many [software vendors](https://technical.buildingsmart.org/ids-software-implementations/). Any IFC model produced from any software can be checked against an IDS file.

## The IDS structure

Each IDS file can be described with [metadata](ids-metadata.md), and can contain one or more [specifications](specifications.md). Specifications consist of two parts: applicability - describing what elements are subject to this specification, and requirements - listing what those applicable elements should or shouldn't have. Both applicability and requirements are built with facets, such as property, entity, classification, material or partOf.

## How to start

 1. Choose software that supports IDS checking (see [list of tools supporting IDS](https://technical.buildingsmart.org/ids-software-implementations/)).
 2. Download a [sample IDS file](../Examples/IDS_wooden-windows.ids).
 3. Download a [sample IFC model](../Examples/IDS_wooden-windows_IFC.ifc) to check against the IDS.
 4. Load both the IDS and the IFC in your software and begin the checking process.
 5. You should obtain a report of all the non-compliances.

That's it! You may also find more sample IDS files in the [Examples](../Examples). If you need help, please feel free to ask for help on the [buildingSMART Forums](https://forums.buildingsmart.org/).

## Learn more about IDS

 1. [How **Specifications** work?](specifications.md)
 1. [Guidelines on specifying good **Specification** metadata](ids-metadata.md)
 1. [Learn how to specify **Complex Restrictions**](restrictions.md)
 1. [Learn how to use the **Entity Facet**](entity-facet.md)
 1. [Learn how to use the **Attribute Facet**](attribute-facet.md)
 1. [Learn how to use the **Classification Facet**](classification-facet.md)
 1. [Learn how to use the **Property Facet**](property-facet.md)
 1. [Learn how to use the **Material Facet**](material-facet.md)
 1. [Learn how to use the **PartOf Facet**](partof-facet.md)
 1. [Are you a software developer? Read the developer guide!](../ImplementersDocumentation/developer-guide.md)
