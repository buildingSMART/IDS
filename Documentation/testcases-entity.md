# Entity testcases

These testcases are designed to help describe behaviour in edge cases and ambiguities. All valid IDS implementations must demonstrate identical behaviour to these test cases.

## [FAIL] Invalid entities always fail

~~~xml
<entity>
  <name>
    <simpleValue>IFCRABBIT</simpleValue>
  </name>
</entity>
~~~

~~~lua
#1=IFCWALL('0bziUpHHb538fov9u7Lsl9',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/fail-invalid_entities_always_fail.ids) - [Sample IFC: 1](testcases/fail-invalid_entities_always_fail.ifc)

## [PASS] A matching entity should pass

~~~xml
<entity>
  <name>
    <simpleValue>IFCWALL</simpleValue>
  </name>
</entity>
~~~

~~~lua
#1=IFCWALL('1yTM9eiGX5jx7gpHqwcmKe',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/pass-a_matching_entity_should_pass.ids) - [Sample IFC: 1](testcases/pass-a_matching_entity_should_pass.ifc)

## [PASS] An matching entity should pass regardless of predefined type

~~~xml
<entity>
  <name>
    <simpleValue>IFCWALL</simpleValue>
  </name>
</entity>
~~~

~~~lua
#1=IFCWALL('0DPnCjnmD6_AfI6sLoNhus',$,$,$,$,$,$,$,.SOLIDWALL.); /* Testcase */
~~~

[Sample IDS](testcases/pass-an_matching_entity_should_pass_regardless_of_predefined_type.ids) - [Sample IFC: 1](testcases/pass-an_matching_entity_should_pass_regardless_of_predefined_type.ifc)

## [FAIL] An entity not matching the specified class should fail

~~~xml
<entity>
  <name>
    <simpleValue>IFCWALL</simpleValue>
  </name>
</entity>
~~~

~~~lua
#1=IFCSLAB('0lyDsfhm15IfI0WHEUDFhp',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/fail-an_entity_not_matching_the_specified_class_should_fail.ids) - [Sample IFC: 1](testcases/fail-an_entity_not_matching_the_specified_class_should_fail.ifc)

## [FAIL] Subclasses are not considered as matching

~~~xml
<entity>
  <name>
    <simpleValue>IFCWALL</simpleValue>
  </name>
</entity>
~~~

~~~lua
#1=IFCWALLSTANDARDCASE('1lg8oDVpf0KuarRewjGUIv',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/fail-subclasses_are_not_considered_as_matching.ids) - [Sample IFC: 1](testcases/fail-subclasses_are_not_considered_as_matching.ifc)

## [FAIL] Entities must be specified as uppercase strings

~~~xml
<entity>
  <name>
    <simpleValue>IfcWall</simpleValue>
  </name>
</entity>
~~~

~~~lua
#1=IFCWALL('0gnz5aO8rBXOI8Da3mwJ9Z',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/fail-entities_must_be_specified_as_uppercase_strings.ids) - [Sample IFC: 1](testcases/fail-entities_must_be_specified_as_uppercase_strings.ifc)

## [PASS] A matching predefined type should pass

~~~xml
<entity>
  <name>
    <simpleValue>IFCWALL</simpleValue>
  </name>
  <predefinedType>
    <simpleValue>SOLIDWALL</simpleValue>
  </predefinedType>
</entity>
~~~

~~~lua
#1=IFCWALL('3QxiEep1970RjLzhHenAlw',$,$,$,$,$,$,$,.SOLIDWALL.); /* Testcase */
~~~

[Sample IDS](testcases/pass-a_matching_predefined_type_should_pass.ids) - [Sample IFC: 1](testcases/pass-a_matching_predefined_type_should_pass.ifc)

## [FAIL] A null predefined type should always fail a specified predefined types

~~~xml
<entity>
  <name>
    <simpleValue>IFCWALL</simpleValue>
  </name>
  <predefinedType>
    <simpleValue>SOLIDWALL</simpleValue>
  </predefinedType>
</entity>
~~~

~~~lua
#1=IFCWALL('3hX7Q2CMrA89UgAc0HAauJ',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/fail-a_null_predefined_type_should_always_fail_a_specified_predefined_types.ids) - [Sample IFC: 1](testcases/fail-a_null_predefined_type_should_always_fail_a_specified_predefined_types.ifc)

## [FAIL] An entity not matching a specified predefined type will fail

~~~xml
<entity>
  <name>
    <simpleValue>IFCWALL</simpleValue>
  </name>
  <predefinedType>
    <simpleValue>SOLIDWALL</simpleValue>
  </predefinedType>
</entity>
~~~

~~~lua
#1=IFCWALL('3lMFFm9kP03PH$35Barisc',$,$,$,$,$,$,$,.PARTITIONING.); /* Testcase */
~~~

[Sample IDS](testcases/fail-an_entity_not_matching_a_specified_predefined_type_will_fail.ids) - [Sample IFC: 1](testcases/fail-an_entity_not_matching_a_specified_predefined_type_will_fail.ifc)

## [FAIL] A predefined type from an enumeration must be uppercase

~~~xml
<entity>
  <name>
    <simpleValue>IFCWALL</simpleValue>
  </name>
  <predefinedType>
    <simpleValue>solidwall</simpleValue>
  </predefinedType>
</entity>
~~~

~~~lua
#1=IFCWALL('2lFXfmA6z508OXyTOybtpc',$,$,$,$,$,$,$,.SOLIDWALL.); /* Testcase */
~~~

[Sample IDS](testcases/fail-a_predefined_type_from_an_enumeration_must_be_uppercase.ids) - [Sample IFC: 1](testcases/fail-a_predefined_type_from_an_enumeration_must_be_uppercase.ifc)

## [PASS] A predefined type may specify a user-defined object type

~~~xml
<entity>
  <name>
    <simpleValue>IFCWALL</simpleValue>
  </name>
  <predefinedType>
    <simpleValue>WALDO</simpleValue>
  </predefinedType>
</entity>
~~~

~~~lua
#1=IFCWALL('1IayCfZI12fvRCC4G1j36c',$,$,$,'WALDO',$,$,$,.USERDEFINED.); /* Testcase */
~~~

[Sample IDS](testcases/pass-a_predefined_type_may_specify_a_user_defined_object_type.ids) - [Sample IFC: 1](testcases/pass-a_predefined_type_may_specify_a_user_defined_object_type.ifc)

## [FAIL] User-defined types are checked case sensitively

~~~xml
<entity>
  <name>
    <simpleValue>IFCWALL</simpleValue>
  </name>
  <predefinedType>
    <simpleValue>WALDO</simpleValue>
  </predefinedType>
</entity>
~~~

~~~lua
#1=IFCWALL('2ecfUPMe1BN87v6P0rBzjT',$,$,$,'waldo',$,$,$,.USERDEFINED.); /* Testcase */
~~~

[Sample IDS](testcases/fail-user_defined_types_are_checked_case_sensitively.ids) - [Sample IFC: 1](testcases/fail-user_defined_types_are_checked_case_sensitively.ifc)

## [PASS] A predefined type may specify a user-defined element type

~~~xml
<entity>
  <name>
    <simpleValue>IFCWALLTYPE</simpleValue>
  </name>
  <predefinedType>
    <simpleValue>WALDO</simpleValue>
  </predefinedType>
</entity>
~~~

~~~lua
#1=IFCWALLTYPE('3FSPLBZF93nAHg4xE3mSNS',$,$,$,$,$,$,$,'WALDO',.USERDEFINED.); /* Testcase */
~~~

[Sample IDS](testcases/pass-a_predefined_type_may_specify_a_user_defined_element_type.ids) - [Sample IFC: 1](testcases/pass-a_predefined_type_may_specify_a_user_defined_element_type.ifc)

## [PASS] A predefined type may specify a user-defined process type

~~~xml
<entity>
  <name>
    <simpleValue>IFCTASKTYPE</simpleValue>
  </name>
  <predefinedType>
    <simpleValue>TASKY</simpleValue>
  </predefinedType>
</entity>
~~~

~~~lua
#1=IFCTASKTYPE('180B8D4KbFXfFN35aUwF0v',$,$,$,$,$,$,$,'TASKY',.USERDEFINED.,$); /* Testcase */
~~~

[Sample IDS](testcases/pass-a_predefined_type_may_specify_a_user_defined_process_type.ids) - [Sample IFC: 1](testcases/pass-a_predefined_type_may_specify_a_user_defined_process_type.ifc)

## [FAIL] A predefined type must always specify a meaningful type, not USERDEFINED itself

~~~xml
<entity>
  <name>
    <simpleValue>IFCWALL</simpleValue>
  </name>
  <predefinedType>
    <simpleValue>USERDEFINED</simpleValue>
  </predefinedType>
</entity>
~~~

~~~lua
#1=IFCWALL('2emAGFrs5DGu$vYROns4EL',$,$,$,'WALDO',$,$,$,.USERDEFINED.); /* Testcase */
~~~

[Sample IDS](testcases/fail-a_predefined_type_must_always_specify_a_meaningful_type__not_userdefined_itself.ids) - [Sample IFC: 1](testcases/fail-a_predefined_type_must_always_specify_a_meaningful_type__not_userdefined_itself.ifc)

## [PASS] Inherited predefined types should pass

~~~xml
<entity>
  <name>
    <simpleValue>IFCWALL</simpleValue>
  </name>
  <predefinedType>
    <simpleValue>X</simpleValue>
  </predefinedType>
</entity>
~~~

~~~lua
#1=IFCWALL('3uBNXcbZfEER4V5ISZHxa4',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCWALLTYPE('1b4wJS_5XEuOEm$Fy$d05j',$,$,$,$,$,$,$,'X',.USERDEFINED.);
#3=IFCRELDEFINESBYTYPE('2PevMQbNn6IQrnTn6mr9mY',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/pass-inherited_predefined_types_should_pass.ids) - [Sample IFC: 1](testcases/pass-inherited_predefined_types_should_pass.ifc)

## [PASS] Overridden predefined types should pass

~~~xml
<entity>
  <name>
    <simpleValue>IFCWALL</simpleValue>
  </name>
  <predefinedType>
    <simpleValue>X</simpleValue>
  </predefinedType>
</entity>
~~~

~~~lua
#1=IFCWALL('1OMDXrLg52tvgkWQWnN9Kk',$,$,$,'X',$,$,$,.USERDEFINED.); /* Testcase */
#2=IFCWALLTYPE('24kVNldTr5fvFVXxP6ljxr',$,$,$,$,$,$,$,$,.NOTDEFINED.);
#3=IFCRELDEFINESBYTYPE('3nCzJtVmj68Op7z5jlRk8h',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/pass-overridden_predefined_types_should_pass.ids) - [Sample IFC: 1](testcases/pass-overridden_predefined_types_should_pass.ifc)

## [PASS] Entities can be specified as an enumeration 1/3

~~~xml
<entity>
  <name>
    <xs:restriction base="xs:string">
      <xs:enumeration value="IFCWALL"/>
      <xs:enumeration value="IFCSLAB"/>
    </xs:restriction>
  </name>
</entity>
~~~

~~~lua
#1=IFCWALL('1Qay_22En1le9QrVmHaBQl',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/pass-entities_can_be_specified_as_an_enumeration_1_3.ids) - [Sample IFC: 1](testcases/pass-entities_can_be_specified_as_an_enumeration_1_3.ifc)

## [PASS] Entities can be specified as an enumeration 2/3

~~~xml
<entity>
  <name>
    <xs:restriction base="xs:string">
      <xs:enumeration value="IFCWALL"/>
      <xs:enumeration value="IFCSLAB"/>
    </xs:restriction>
  </name>
</entity>
~~~

~~~lua
#1=IFCSLAB('2lzg5zcdb8DvONp3SyU6uf',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/pass-entities_can_be_specified_as_an_enumeration_2_3.ids) - [Sample IFC: 1](testcases/pass-entities_can_be_specified_as_an_enumeration_2_3.ifc)

## [FAIL] Entities can be specified as an enumeration 3/3

~~~xml
<entity>
  <name>
    <xs:restriction base="xs:string">
      <xs:enumeration value="IFCWALL"/>
      <xs:enumeration value="IFCSLAB"/>
    </xs:restriction>
  </name>
</entity>
~~~

~~~lua
#1=IFCBEAM('3VC5ta4az6afdtXVldU1Ur',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/fail-entities_can_be_specified_as_an_enumeration_3_3.ids) - [Sample IFC: 1](testcases/fail-entities_can_be_specified_as_an_enumeration_3_3.ifc)

## [FAIL] Entities can be specified as a XSD regex pattern 1/2

~~~xml
<entity>
  <name>
    <xs:restriction base="xs:string">
      <xs:pattern value="IFC.*TYPE"/>
    </xs:restriction>
  </name>
</entity>
~~~

~~~lua
#1=IFCWALL('1mRO0SerX5Yh1Fyt53ZEG$',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/fail-entities_can_be_specified_as_a_xsd_regex_pattern_1_2.ids) - [Sample IFC: 1](testcases/fail-entities_can_be_specified_as_a_xsd_regex_pattern_1_2.ifc)

## [PASS] Entities can be specified as a XSD regex pattern 2/2

~~~xml
<entity>
  <name>
    <xs:restriction base="xs:string">
      <xs:pattern value="IFC.*TYPE"/>
    </xs:restriction>
  </name>
</entity>
~~~

~~~lua
#1=IFCWALLTYPE('1os_WLhsPCnxUxc$pshDKq',$,$,$,$,$,$,$,$,.ELEMENTEDWALL.); /* Testcase */
~~~

[Sample IDS](testcases/pass-entities_can_be_specified_as_a_xsd_regex_pattern_2_2.ids) - [Sample IFC: 1](testcases/pass-entities_can_be_specified_as_a_xsd_regex_pattern_2_2.ifc)

## [PASS] Restrictions an be specified for the predefined type 1/3

~~~xml
<entity>
  <name>
    <simpleValue>IFCWALL</simpleValue>
  </name>
  <predefinedType>
    <xs:restriction base="xs:string">
      <xs:pattern value="FOO.*"/>
    </xs:restriction>
  </predefinedType>
</entity>
~~~

~~~lua
#1=IFCWALL('1z1B8SO$LAovq6YP4X_x9n',$,$,$,'FOOBAR',$,$,$,.USERDEFINED.); /* Testcase */
~~~

[Sample IDS](testcases/pass-restrictions_an_be_specified_for_the_predefined_type_1_3.ids) - [Sample IFC: 1](testcases/pass-restrictions_an_be_specified_for_the_predefined_type_1_3.ifc)

## [PASS] Restrictions an be specified for the predefined type 2/3

~~~xml
<entity>
  <name>
    <simpleValue>IFCWALL</simpleValue>
  </name>
  <predefinedType>
    <xs:restriction base="xs:string">
      <xs:pattern value="FOO.*"/>
    </xs:restriction>
  </predefinedType>
</entity>
~~~

~~~lua
#1=IFCWALL('3vCKrTy4b71P$m1jP1z6Vv',$,$,$,'FOOBAZ',$,$,$,.USERDEFINED.); /* Testcase */
~~~

[Sample IDS](testcases/pass-restrictions_an_be_specified_for_the_predefined_type_2_3.ids) - [Sample IFC: 1](testcases/pass-restrictions_an_be_specified_for_the_predefined_type_2_3.ifc)

## [FAIL] Restrictions an be specified for the predefined type 3/3

~~~xml
<entity>
  <name>
    <simpleValue>IFCWALL</simpleValue>
  </name>
  <predefinedType>
    <xs:restriction base="xs:string">
      <xs:pattern value="FOO.*"/>
    </xs:restriction>
  </predefinedType>
</entity>
~~~

~~~lua
#1=IFCWALL('0hsNJQacT3iwFeJmHBH_XL',$,$,$,'BAZFOO',$,$,$,.USERDEFINED.); /* Testcase */
~~~

[Sample IDS](testcases/fail-restrictions_an_be_specified_for_the_predefined_type_3_3.ids) - [Sample IFC: 1](testcases/fail-restrictions_an_be_specified_for_the_predefined_type_3_3.ifc)

