# BuildingSmart's Information Delivery Specification Format

Proposal for BuildingSmart's IDS standard for interoperable information requirements
in the context of construction projects.

Author: Claudio Benghi

Date: 15th February 2021

## Principles

### Process aware

the format is arranged so that the specification writing process can be
easily broken down between the various roles involved in AEC processes.

- [ ] business stakeholders will have the opportunity to define the requirements around project-specific model-breakdown criteria
- [ ] workflow specialists will define the technical implementation

### Modular

Version 1.0 of the format is designed to provide immediate interoperable
features to address the majority of industry's needs with moderate
implementation challenges, while retaining an extensible data structure for
robust progressive expansion of use-case coverage.

### Industry driven

The format is developed starting from the industrial needs and use cases emerging
from the community rather than the features available in the existing IT toolkits.

### Progressive

Comply with common industrial practice, yet encourage best-practice.
When dealing with potential conflict between wide-spread behaviours and best practices a solution
will be sought to enable large adoption but will not force sub-optimal approaches.

Balancing this with preventing 'gold-plating'... e.g. not too many features.

### Open

The standard will be open and use existing and wide-spread technologies and standards whenever possible to
reduce implementation efforts.

## Proposal

Use XML format for the specification of requirements. Provide an open and free implementation library that
can be used without specific licensing agreements by any party, even in commercial environments.

### Smallest specification file

The simplest requirements file has the following form:

``` xml
<IDS>
    <Requirements>
        <Requirement>
            <ModelSubset><IfcTypeQuery IfcType="IfcWall" IncludeSubtypes="false" /></ModelSubset>
            <Need><HasProperty PropertySetName="Pset_WallCommon" PropertyName="IsExternal" PropertyType="IfcBoolean" /></Need>
        </Requirement>
    </Requirements>
</IDS>    
```

This basic form is directly expressing the two fundamental components of a specification:

- **Need**: defines the expected information.
- **ModelSubSet**: identifies the subset of a model that the _need_ applies to.

As a general rule, each entity in the model that belongs to `ModelSubSet` needs to comply with the rule
set by the need.

In this case the single requirement is interpreted as follows:  

Part | Type | Required / Default | Notes
-----|------|--------------------|-------
**IfcTypeQuery** | Node | n/a | Identifies entities by their type in the IFC model.
IfcType | Attribute | Required | The name of IfcType that needs to be matched (case insensitive). E.g. `IfcProduct` or `ifcwall`.
IncludeSubtypes | Attribute | 'true' | if true include all subtypes, otherwise only exact match. E.g. if `true` will match IfcWallStandardCase for `IfcWall`.
**HasProperty** | Node | n/a | Defines that a property exist, and optionally some constraints
PropertySetName | Attribute | Optional | Defines the name of the PropertySet where to find the Property, if not defined search in all available property sets.
PropertyName | Attribute | Required | A not null or empty string to match.
PropertyType | Attribute | Optional | A constraint on the type of the value of the property. Case insensitive, will be satisfied by any subtypes, e.g. `IfcSimpleValue` would be satisfied by `IfcInteger`, `IfcReal`, `IfcBoolean`, `IfcIdentifier`, `IfcText`, `IfcLabel` or `IfcLogical`.

#### Implementation notes

- `IfcTypeQuery.IncludeSubtypes` requires knowledge of the IFC inheritance schema, that can easily be encapsulated in static constants.
- TODO: For `HasProperty` decide what are the relations that need to be investigated in the search. E.g. do properties attached via the IfcType qualify?

### Progressive requirement definition

AKA Separation of concerns

A more flexible workflow allows the progressive definition of information requirements by multiple parties and at different time frames in the project.

For example the following initial form, would anticipate the expected information for an element set arbitrarily named `Walls manufactured offsite`.

This allows to separate the conversation about information needs from the technical implementation, that can be discussed later.

``` xml
<IDS>
    <Requirements>
        <Requirement>
            <ModelSubset ref="Walls manufactured offsite" />
            <Need><HasProperty PropertySetName="Pset_WallCommon" PropertyName="FireRating" PropertyType="IfcLabel" /></Need>
        </Requirement>
    </Requirements>
</IDS>
```

The new parts of the schema introduced are:

Part | Type | Required / Default | Notes
-----|------|--------------------|-------
**ModelSubSet** | Node | Required | The node defines the set of entities to be tested
ref | Attribute | Optional | Defines an arbitrary name of the subset, it is required if there is no node inside the ModelSubSet that identify the entities.

### Internal references

The same concept, expanded with greater guidance to the technical team, could be defined by using internal libraries form `ModelSets` as follows:

``` xml
<IDS>
     <ModelSets>
        <ModelSubset name="Walls manufactured offsite" description="Walls will be marked for offsite manufacturing via a property to be defined" />
    </ModelSets>
    <Requirements>
        <Requirement>
            <ModelSubset ref="Walls manufactured offsite" />
            <Need><HasProperty propertySetName="Pset_WallCommon" propertyName="FireRating" propertyType="IfcLabel" /></Need>
        </Requirement>
    </Requirements>
</IDS>
```

In this example, the `ModelSets` node allows the definition of model subsets that can be reused several times in the requirements file, allowing to retain many attributes like `Description` with minimal information repetition.

As presented, the specification is still incomplete (i.e. it lack essential information to be able to know where to place the
information required), however it's valid and useful for negotiating and developing the technical implementation.

The `Description` attribute is optional, but allows to describe the nature of the intended model subset.

Eventually, the specifications will be completed with all the implementation details, for example:

``` xml
<IDS>
     <ModelSets>
        <ModelSubset name="Everything offsite"
           description="Everything for offsite manufacturing need to have the company name" >
           <IfcPropertyQuery propertySetName="Pset_Manufacturing" propertyName="Location" propertyValue="Offsite" />
       </ModelSubset>
       <ModelSubset name="Walls manufactured offsite"
           description="All walls scheduled for offsite manufacturing need to be identified via the Pset_Manufacturing.Location property set to Offsite" >
           <IfcPropertyQuery propertySetName="Pset_Manufacturing" propertyName="Location" propertyValue="Offsite" />
           <IfcTypeQuery ifcType="IfcWall" />
       </ModelSubset>
        <ModelSubset name="Doors manufactured offsite"
           description="All doors scheduled for offsite manufacturing need to be identified via the Pset_Manufacturing.Location property set to Offsite" >
           <IfcPropertyQuery propertySetName="Pset_Manufacturing" propertyName="Location" propertyValue="Offsite" />
           <IfcTypeQuery ifcType="IfcDoor" />
       </ModelSubset>
   </ModelSets>
   <Requirements>
       <Requirement>
           <ModelSubset ref="Walls manufactured offsite" />
           <Need><HasProperty propertySetName="Pset_WallCommon" propertyName="FireRating" propertyType="IfcLabel" /></Need>
       </Requirement>
       <Requirement>
           <ModelSubset ref="Everything offsite" />
           <Need><HasProperty propertySetName="Pset_Process" propertyName="Company" propertyType="IfcLabel" /></Need>
       </Requirement>
   </Requirements>
</IDS>
```

In this scenario the `PropertyQuery` node is used to identify the subset of elements to test by finding entities that have the `Offsite` value in the `Pset_Manufacturing.Location` property.
The `PropertyQuery` node alone might be sufficient to identify the desired entitites, but the addition of `IfcTypeQuery` can be used to discriminate requirements for all the relevant parts of the model.

#### Implementation notes

All the nodes within a `ModelSubSet` will be evaluated with a logic `AND` to determine the extent of the model subset, in this example only elements of type IfcWall with the Location property set to Offsite.

### Collection repetition

The `ModelSets` and `Requirements` nodes can be repeated as many times as neededed to allow grouping, if desired as follows:

``` xml
<IDS>
    <ModelSets>
        <ModelSubset name="Walls manufactured offsite"
            description="All walls scheduled for offsite manufacturing need to be identified via the Pset_Manufacturing.Location property set to Offsite" >
            <IfcPropertyQuery propertySetName="Pset_Manufacturing" propertyName="Location" propertyValue="Offsite" />
        </ModelSubset>
    </ModelSets>
    <Requirements>
        <!-- We are reusing the requirements node if we want to inherit stages and other information for the child requirements -->     
        <Stage>4</Stage>    
        <Requirement>
            <ModelSubset ref="Walls manufactured offsite" />
            <Need><HasProperty propertySetName="Pset_WallCommon" propertyName="FireRating" propertyType="IfcLabel" /></Need>
        </Requirement>
          
    </Requirements>
    <Requirements>
        <Stage>5</Stage>
        <Stage>6</Stage>
        <Requirement>
            <!-- Pointing to the previously defined ModelSubSet simplifies the creation of each requirement. -->
            <ModelSubset ref="Walls manufactured offsite" />
            <Need><HasDocumentReference documentName="FireCertificate" documentStatus="FINAL" requiredAttributes="Location,ElectronicFormat,ValidUntil" /></Need>
        </Requirement>
    </Requirements>
</IDS>
```

### Model breakdown first

TODO: Groups first, requirements later.

### Multiple formats

The concept of internal references and separation of concerns can further be exploited to isolate the formats chosen for delivery.

In the future, the XML structure could easily be expanded to make the IDS suitable for multiple format standards, retaining the same structure for the `Requirements` node, and all the work done for the association of requirements to model elements.

``` xml
<ModelSubSet Name="Walls manufactured offsite">
  <Schema format="IFC4">
    <... />
  </Schema>
  <Schema format="Cobie">
    <... />
  </Schema>
</ModelSubSet>
```
