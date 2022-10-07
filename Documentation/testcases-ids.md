# IDS integration testcases

These testcases are designed to help describe behaviour in edge cases and ambiguities. All valid IDS implementations must demonstrate identical behaviour to these test cases.

## [FAIL] A minimal IDS can check a minimal IFC 1/2

~~~xml
<specifications>
    <specification name="Name" ifcVersion="IFC2X3 IFC4" minOccurs="0" maxOccurs="unbounded">
        <applicability>
            <entity>
                <name>
                    <simpleValue>IFCWALL</simpleValue>
                </name>
            </entity>
        </applicability>
        <requirements>
            <attribute minOccurs="1" maxOccurs="1">
                <name>
                    <simpleValue>Name</simpleValue>
                </name>
                <value>
                    <simpleValue>Waldo</simpleValue>
                </value>
            </attribute>
        </requirements>
    </specification>
</specifications>
~~~

~~~lua
[FAIL] #1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$);
[PASS] #2=IFCWALL('0eA6m4fELI9QBIhP3wiLAp',$,'Waldo',$,$,$,$,$,$);
~~~

```
# ❌ Specification (optional)
Applies to:
 - All IFCWALL data
Requirements:
 - ❌ The Name shall be Waldo (required)
```

[Sample IDS](testcases/ids/fail-a_minimal_ids_can_check_a_minimal_ifc_1_2.ids) - [Sample IFC](testcases/ids/fail-a_minimal_ids_can_check_a_minimal_ifc_1_2.ifc)

## [PASS] A minimal IDS can check a minimal IFC 2/2

~~~xml
<specifications>
    <specification name="Name" ifcVersion="IFC2X3 IFC4" minOccurs="0" maxOccurs="unbounded">
        <applicability>
            <entity>
                <name>
                    <simpleValue>IFCWALL</simpleValue>
                </name>
            </entity>
        </applicability>
        <requirements>
            <attribute minOccurs="1" maxOccurs="1">
                <name>
                    <simpleValue>Name</simpleValue>
                </name>
                <value>
                    <simpleValue>Waldo</simpleValue>
                </value>
            </attribute>
        </requirements>
    </specification>
</specifications>
~~~

~~~lua
[PASS] #1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Waldo',$,$,$,$,$,$);
[PASS] #2=IFCWALL('0eA6m4fELI9QBIhP3wiLAp',$,'Waldo',$,$,$,$,$,$);
~~~

```
# ✔️ Specification (optional)
Applies to:
 - All IFCWALL data
Requirements:
 - ✔️ The Name shall be Waldo (required)
```

[Sample IDS](testcases/ids/pass-a_minimal_ids_can_check_a_minimal_ifc_2_2.ids) - [Sample IFC](testcases/ids/pass-a_minimal_ids_can_check_a_minimal_ifc_2_2.ifc)

## [PASS] Specification version is purely metadata and does not impact pass or fail result

~~~xml
<specifications>
    <specification name="Name" ifcVersion="IFC2X3" minOccurs="0" maxOccurs="unbounded">
        <applicability>
            <entity>
                <name>
                    <simpleValue>IFCWALL</simpleValue>
                </name>
            </entity>
        </applicability>
        <requirements>
            <attribute minOccurs="1" maxOccurs="1">
                <name>
                    <simpleValue>Name</simpleValue>
                </name>
                <value>
                    <simpleValue>Waldo</simpleValue>
                </value>
            </attribute>
        </requirements>
    </specification>
</specifications>
~~~

~~~lua
[PASS] #1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Waldo',$,$,$,$,$,$);
[PASS] #2=IFCWALL('0eA6m4fELI9QBIhP3wiLAp',$,'Waldo',$,$,$,$,$,$);
~~~

```
# ✔️ Specification (optional)
Applies to:
 - All IFCWALL data
Requirements:
 - ✔️ The Name shall be Waldo (required)
```

[Sample IDS](testcases/ids/pass-specification_version_is_purely_metadata_and_does_not_impact_pass_or_fail_result.ids) - [Sample IFC](testcases/ids/pass-specification_version_is_purely_metadata_and_does_not_impact_pass_or_fail_result.ifc)

## [PASS] Required specifications need at least one applicable entity 1/2

~~~xml
<specifications>
    <specification name="Name" ifcVersion="" minOccurs="1" maxOccurs="unbounded">
        <applicability>
            <entity>
                <name>
                    <simpleValue>IFCWALL</simpleValue>
                </name>
            </entity>
        </applicability>
        <requirements>
            <attribute minOccurs="1" maxOccurs="1">
                <name>
                    <simpleValue>Name</simpleValue>
                </name>
                <value>
                    <simpleValue>Waldo</simpleValue>
                </value>
            </attribute>
        </requirements>
    </specification>
</specifications>
~~~

~~~lua
[PASS] #1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Waldo',$,$,$,$,$,$);
~~~

```
# ✔️ Specification (required)
Applies to:
 - All IFCWALL data
Requirements:
 - ✔️ The Name shall be Waldo (required)
```

[Sample IDS](testcases/ids/pass-required_specifications_need_at_least_one_applicable_entity_1_2.ids) - [Sample IFC](testcases/ids/pass-required_specifications_need_at_least_one_applicable_entity_1_2.ifc)

## [FAIL] Required specifications need at least one applicable entity 2/2

~~~xml
<specifications>
    <specification name="Name" ifcVersion="" minOccurs="1" maxOccurs="unbounded">
        <applicability>
            <entity>
                <name>
                    <simpleValue>IFCWALL</simpleValue>
                </name>
            </entity>
        </applicability>
        <requirements>
            <attribute minOccurs="1" maxOccurs="1">
                <name>
                    <simpleValue>Name</simpleValue>
                </name>
                <value>
                    <simpleValue>Waldo</simpleValue>
                </value>
            </attribute>
        </requirements>
    </specification>
</specifications>
~~~

~~~lua
       #1=IFCSLAB('1hqIFTRjfV6AWq_bMtnZwI',$,'Waldo',$,$,$,$,$,$);
~~~

```
# ❌ Specification (required)
Applies to:
 - All IFCWALL data
Requirements:
 - ❌ The Name shall be Waldo (required)
```

[Sample IDS](testcases/ids/fail-required_specifications_need_at_least_one_applicable_entity_2_2.ids) - [Sample IFC](testcases/ids/fail-required_specifications_need_at_least_one_applicable_entity_2_2.ifc)

## [PASS] Optional specifications may still pass if nothing is applicable

~~~xml
<specifications>
    <specification name="Name" ifcVersion="" minOccurs="0" maxOccurs="unbounded">
        <applicability>
            <entity>
                <name>
                    <simpleValue>IFCWALL</simpleValue>
                </name>
            </entity>
        </applicability>
        <requirements>
            <attribute minOccurs="1" maxOccurs="1">
                <name>
                    <simpleValue>Name</simpleValue>
                </name>
                <value>
                    <simpleValue>Waldo</simpleValue>
                </value>
            </attribute>
        </requirements>
    </specification>
</specifications>
~~~

~~~lua
       #1=IFCSLAB('1hqIFTRjfV6AWq_bMtnZwI',$,'Waldo',$,$,$,$,$,$);
~~~

```
# ✔️ Specification (optional)
Applies to:
 - All IFCWALL data
Requirements:
 - ✔️ The Name shall be Waldo (required)
```

[Sample IDS](testcases/ids/pass-optional_specifications_may_still_pass_if_nothing_is_applicable.ids) - [Sample IFC](testcases/ids/pass-optional_specifications_may_still_pass_if_nothing_is_applicable.ifc)

## [PASS] Prohibited specifications fail if at least one entity passes all requirements 1/3

~~~xml
<specifications>
    <specification name="Name" ifcVersion="" minOccurs="0" maxOccurs="0">
        <applicability>
            <entity>
                <name>
                    <simpleValue>IFCWALL</simpleValue>
                </name>
            </entity>
        </applicability>
        <requirements>
            <attribute minOccurs="1" maxOccurs="1">
                <name>
                    <simpleValue>Name</simpleValue>
                </name>
                <value>
                    <simpleValue>Waldo</simpleValue>
                </value>
            </attribute>
        </requirements>
    </specification>
</specifications>
~~~

~~~lua
       #1=IFCSLAB('1hqIFTRjfV6AWq_bMtnZwI',$,'Waldo',$,$,$,$,$,$);
~~~

```
# ✔️ Specification (prohibited)
Applies to:
 - All IFCWALL data
Requirements:
 - ✔️ The Name shall be Waldo (required)
```

[Sample IDS](testcases/ids/pass-prohibited_specifications_fail_if_at_least_one_entity_passes_all_requirements_1_3.ids) - [Sample IFC](testcases/ids/pass-prohibited_specifications_fail_if_at_least_one_entity_passes_all_requirements_1_3.ifc)

## [PASS] Prohibited specifications fail if at least one entity passes all requirements 2/3

~~~xml
<specifications>
    <specification name="Name" ifcVersion="" minOccurs="0" maxOccurs="0">
        <applicability>
            <entity>
                <name>
                    <simpleValue>IFCWALL</simpleValue>
                </name>
            </entity>
        </applicability>
        <requirements>
            <attribute minOccurs="1" maxOccurs="1">
                <name>
                    <simpleValue>Name</simpleValue>
                </name>
                <value>
                    <simpleValue>Waldo</simpleValue>
                </value>
            </attribute>
        </requirements>
    </specification>
</specifications>
~~~

~~~lua
[FAIL] #1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Wally',$,$,$,$,$,$);
~~~

```
# ✔️ Specification (prohibited)
Applies to:
 - All IFCWALL data
Requirements:
 - ❌ The Name shall be Waldo (required)
```

[Sample IDS](testcases/ids/pass-prohibited_specifications_fail_if_at_least_one_entity_passes_all_requirements_2_3.ids) - [Sample IFC](testcases/ids/pass-prohibited_specifications_fail_if_at_least_one_entity_passes_all_requirements_2_3.ifc)

## [FAIL] Prohibited specifications fail if at least one entity passes all requirements 3/3

~~~xml
<specifications>
    <specification name="Name" ifcVersion="" minOccurs="0" maxOccurs="0">
        <applicability>
            <entity>
                <name>
                    <simpleValue>IFCWALL</simpleValue>
                </name>
            </entity>
        </applicability>
        <requirements>
            <attribute minOccurs="1" maxOccurs="1">
                <name>
                    <simpleValue>Name</simpleValue>
                </name>
                <value>
                    <simpleValue>Waldo</simpleValue>
                </value>
            </attribute>
        </requirements>
    </specification>
</specifications>
~~~

~~~lua
[PASS] #1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Waldo',$,$,$,$,$,$);
~~~

```
# ❌ Specification (prohibited)
Applies to:
 - All IFCWALL data
Requirements:
 - ✔️ The Name shall be Waldo (required)
```

[Sample IDS](testcases/ids/fail-prohibited_specifications_fail_if_at_least_one_entity_passes_all_requirements_3_3.ids) - [Sample IFC](testcases/ids/fail-prohibited_specifications_fail_if_at_least_one_entity_passes_all_requirements_3_3.ifc)

## [FAIL] A specification passes only if all requirements pass 1/2

~~~xml
<specifications>
    <specification name="Name" ifcVersion="" minOccurs="0" maxOccurs="unbounded">
        <applicability>
            <entity>
                <name>
                    <simpleValue>IFCWALL</simpleValue>
                </name>
            </entity>
        </applicability>
        <requirements>
            <attribute minOccurs="1" maxOccurs="1">
                <name>
                    <simpleValue>Name</simpleValue>
                </name>
                <value>
                    <simpleValue>Waldo</simpleValue>
                </value>
            </attribute>
            <attribute minOccurs="1" maxOccurs="1">
                <name>
                    <simpleValue>Description</simpleValue>
                </name>
                <value>
                    <simpleValue>Foobar</simpleValue>
                </value>
            </attribute>
        </requirements>
    </specification>
</specifications>
~~~

~~~lua
[FAIL] #1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Waldo',$,$,$,$,$,$);
~~~

```
# ❌ Specification (optional)
Applies to:
 - All IFCWALL data
Requirements:
 - ✔️ The Name shall be Waldo (required)
 - ❌ The Description shall be Foobar (required)
```

[Sample IDS](testcases/ids/fail-a_specification_passes_only_if_all_requirements_pass_1_2.ids) - [Sample IFC](testcases/ids/fail-a_specification_passes_only_if_all_requirements_pass_1_2.ifc)

## [PASS] A specification passes only if all requirements pass 2/2

~~~xml
<specifications>
    <specification name="Name" ifcVersion="" minOccurs="0" maxOccurs="unbounded">
        <applicability>
            <entity>
                <name>
                    <simpleValue>IFCWALL</simpleValue>
                </name>
            </entity>
        </applicability>
        <requirements>
            <attribute minOccurs="1" maxOccurs="1">
                <name>
                    <simpleValue>Name</simpleValue>
                </name>
                <value>
                    <simpleValue>Waldo</simpleValue>
                </value>
            </attribute>
            <attribute minOccurs="1" maxOccurs="1">
                <name>
                    <simpleValue>Description</simpleValue>
                </name>
                <value>
                    <simpleValue>Foobar</simpleValue>
                </value>
            </attribute>
        </requirements>
    </specification>
</specifications>
~~~

~~~lua
[PASS] #1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Waldo','Foobar',$,$,$,$,$);
~~~

```
# ✔️ Specification (optional)
Applies to:
 - All IFCWALL data
Requirements:
 - ✔️ The Name shall be Waldo (required)
 - ✔️ The Description shall be Foobar (required)
```

[Sample IDS](testcases/ids/pass-a_specification_passes_only_if_all_requirements_pass_2_2.ids) - [Sample IFC](testcases/ids/pass-a_specification_passes_only_if_all_requirements_pass_2_2.ifc)

## [PASS] Specification optionality and facet optionality can be combined

~~~xml
<specifications>
    <specification name="Name" ifcVersion="" minOccurs="0" maxOccurs="unbounded">
        <applicability>
            <entity>
                <name>
                    <simpleValue>IFCWALL</simpleValue>
                </name>
            </entity>
        </applicability>
        <requirements>
            <attribute minOccurs="1" maxOccurs="1">
                <name>
                    <simpleValue>Name</simpleValue>
                </name>
                <value>
                    <simpleValue>Waldo</simpleValue>
                </value>
            </attribute>
            <attribute minOccurs="0" maxOccurs="1">
                <name>
                    <simpleValue>Description</simpleValue>
                </name>
                <value>
                    <simpleValue>Foobar</simpleValue>
                </value>
            </attribute>
        </requirements>
    </specification>
</specifications>
~~~

~~~lua
[PASS] #1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Waldo',$,$,$,$,$,$);
~~~

```
# ✔️ Specification (optional)
Applies to:
 - All IFCWALL data
Requirements:
 - ✔️ The Name shall be Waldo (required)
 - ✔️ The Description shall be Foobar (optional)
```

[Sample IDS](testcases/ids/pass-specification_optionality_and_facet_optionality_can_be_combined.ids) - [Sample IFC](testcases/ids/pass-specification_optionality_and_facet_optionality_can_be_combined.ifc)

## [PASS] A prohibited specification and a prohibited facet results in a double negative

~~~xml
<specifications>
    <specification name="Name" ifcVersion="" minOccurs="0" maxOccurs="0">
        <applicability>
            <entity>
                <name>
                    <simpleValue>IFCWALL</simpleValue>
                </name>
            </entity>
        </applicability>
        <requirements>
            <attribute minOccurs="0" maxOccurs="0">
                <name>
                    <simpleValue>Name</simpleValue>
                </name>
                <value>
                    <simpleValue>Waldo</simpleValue>
                </value>
            </attribute>
            <attribute minOccurs="0" maxOccurs="0">
                <name>
                    <simpleValue>Description</simpleValue>
                </name>
                <value>
                    <simpleValue>Foobar</simpleValue>
                </value>
            </attribute>
        </requirements>
    </specification>
</specifications>
~~~

~~~lua
[PASS] #1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Waldo','Foobar',$,$,$,$,$);
~~~

```
# ✔️ Specification (prohibited)
Applies to:
 - All IFCWALL data
Requirements:
 - ✔️ The Name shall be Waldo (prohibited)
 - ✔️ The Description shall be Foobar (prohibited)
```

[Sample IDS](testcases/ids/pass-a_prohibited_specification_and_a_prohibited_facet_results_in_a_double_negative.ids) - [Sample IFC](testcases/ids/pass-a_prohibited_specification_and_a_prohibited_facet_results_in_a_double_negative.ifc)

## [PASS] Multiple specifications are independent of one another

~~~xml
<specifications>
    <specification name="Name" ifcVersion="" minOccurs="0" maxOccurs="0">
        <applicability>
            <entity>
                <name>
                    <simpleValue>IFCWALL</simpleValue>
                </name>
            </entity>
        </applicability>
        <requirements>
            <attribute minOccurs="0" maxOccurs="0">
                <name>
                    <simpleValue>Name</simpleValue>
                </name>
                <value>
                    <simpleValue>Waldo</simpleValue>
                </value>
            </attribute>
            <attribute minOccurs="0" maxOccurs="0">
                <name>
                    <simpleValue>Description</simpleValue>
                </name>
                <value>
                    <simpleValue>Foobar</simpleValue>
                </value>
            </attribute>
        </requirements>
    </specification>
    <specification name="Name" ifcVersion="IFC2X3 IFC4" minOccurs="0" maxOccurs="unbounded">
        <applicability>
            <entity>
                <name>
                    <simpleValue>IFCWALL</simpleValue>
                </name>
            </entity>
        </applicability>
        <requirements>
            <attribute minOccurs="1" maxOccurs="1">
                <name>
                    <simpleValue>Name</simpleValue>
                </name>
                <value>
                    <simpleValue>Waldo</simpleValue>
                </value>
            </attribute>
        </requirements>
    </specification>
</specifications>
~~~

~~~lua
[PASS] #1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Waldo','Foobar',$,$,$,$,$);
[PASS] #2=IFCWALL('0eA6m4fELI9QBIhP3wiLAp',$,'Waldo',$,$,$,$,$,$);
~~~

```
# ✔️ Specification (prohibited)
Applies to:
 - All IFCWALL data
Requirements:
 - ✔️ The Name shall be Waldo (prohibited)
 - ✔️ The Description shall be Foobar (prohibited)
```

```
# ✔️ Specification (optional)
Applies to:
 - All IFCWALL data
Requirements:
 - ✔️ The Name shall be Waldo (required)
```

[Sample IDS](testcases/ids/pass-multiple_specifications_are_independent_of_one_another.ids) - [Sample IFC](testcases/ids/pass-multiple_specifications_are_independent_of_one_another.ifc)

