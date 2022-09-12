# Attribute testcases

These testcases are designed to help describe behaviour in edge cases and ambiguities. All valid IDS implementations must demonstrate identical behaviour to these test cases.

## [FAIL] Invalid attribute names always fail

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Rabbit</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-invalid_attribute_names_always_fail.ids) - [Sample IFC: 1](testcases/attribute/fail-invalid_attribute_names_always_fail.ifc)

## [PASS] Attributes with a string value should pass

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Foobar',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-attributes_with_a_string_value_should_pass.ids) - [Sample IFC: 1](testcases/attribute/pass-attributes_with_a_string_value_should_pass.ifc)

## [PASS] A required facet checks all parameters as normal

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Foobar',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-a_required_facet_checks_all_parameters_as_normal.ids) - [Sample IFC: 1](testcases/attribute/pass-a_required_facet_checks_all_parameters_as_normal.ifc)

## [FAIL] A prohibited facet returns the opposite of a required facet

~~~xml
<attribute minOccurs="0" maxOccurs="0">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Foobar',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-a_prohibited_facet_returns_the_opposite_of_a_required_facet.ids) - [Sample IFC: 1](testcases/attribute/fail-a_prohibited_facet_returns_the_opposite_of_a_required_facet.ifc)

## [PASS] An optional facet always passes regardless of outcome 1/2

~~~xml
<attribute minOccurs="0" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Foobar',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-an_optional_facet_always_passes_regardless_of_outcome_1_2.ids) - [Sample IFC: 1](testcases/attribute/pass-an_optional_facet_always_passes_regardless_of_outcome_1_2.ifc)

## [PASS] An optional facet always passes regardless of outcome 2/2

~~~xml
<attribute minOccurs="0" maxOccurs="1">
  <name>
    <simpleValue>Rabbit</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Foobar',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-an_optional_facet_always_passes_regardless_of_outcome_2_2.ids) - [Sample IFC: 1](testcases/attribute/pass-an_optional_facet_always_passes_regardless_of_outcome_2_2.ifc)

## [FAIL] Attributes with null values always fail

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-attributes_with_null_values_always_fail.ids) - [Sample IFC: 1](testcases/attribute/fail-attributes_with_null_values_always_fail.ifc)

## [FAIL] Attributes with empty strings always fail

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-attributes_with_empty_strings_always_fail.ids) - [Sample IFC: 1](testcases/attribute/fail-attributes_with_empty_strings_always_fail.ifc)

## [PASS] Attributes with a zero number have meaning and should pass

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>CountValue</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCQUANTITYCOUNT('Foobar',$,$,0.,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-attributes_with_a_zero_number_have_meaning_and_should_pass.ids) - [Sample IFC: 1](testcases/attribute/pass-attributes_with_a_zero_number_have_meaning_and_should_pass.ifc)

## [PASS] Attributes with a boolean true should pass

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>IsCritical</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCTASKTIME($,$,$,$,$,$,$,$,$,$,$,$,$,.T.,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-attributes_with_a_boolean_true_should_pass.ids) - [Sample IFC: 1](testcases/attribute/pass-attributes_with_a_boolean_true_should_pass.ifc)

## [PASS] Attributes with a boolean false should pass

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>IsCritical</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCTASKTIME($,$,$,$,$,$,$,$,$,$,$,$,$,.F.,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-attributes_with_a_boolean_false_should_pass.ids) - [Sample IFC: 1](testcases/attribute/pass-attributes_with_a_boolean_false_should_pass.ifc)

## [FAIL] Attributes with an empty list always fail

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RelatingPriorities</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCWALL('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#2=IFCWALL('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,$,$,$,$);
#3=IFCRELCONNECTSPATHELEMENTS('05rScmOVzMoQXOfbYdtLYj',$,$,$,$,#1,#2,(),(),.ATSTART.,.ATEND.); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-attributes_with_an_empty_list_always_fail.ids) - [Sample IFC: 3](testcases/attribute/fail-attributes_with_an_empty_list_always_fail.ifc)

## [FAIL] Attributes with an empty set always fail

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>LayerStyles</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCCARTESIANPOINT((0.,0.,0.));
#2=IFCPRESENTATIONLAYERWITHSTYLE('Foo',$,(#1),$,.T.,.F.,.F.,()); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-attributes_with_an_empty_set_always_fail.ids) - [Sample IFC: 2](testcases/attribute/fail-attributes_with_an_empty_set_always_fail.ifc)

## [FAIL] Attributes with a logical unknown always fail

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>LayerOn</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCCARTESIANPOINT((0.,0.,0.));
#2=IFCPRESENTATIONLAYERWITHSTYLE('Foo',$,(#1),$,.U.,.F.,.F.,()); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-attributes_with_a_logical_unknown_always_fail.ids) - [Sample IFC: 2](testcases/attribute/fail-attributes_with_a_logical_unknown_always_fail.ifc)

## [PASS] Attributes with a zero duration should pass

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>ScheduleDuration</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCTASKTIME($,$,$,$,'P0D',$,$,$,$,$,$,$,$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-attributes_with_a_zero_duration_should_pass.ids) - [Sample IFC: 1](testcases/attribute/pass-attributes_with_a_zero_duration_should_pass.ifc)

## [PASS] Attributes referencing an object should pass

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>TaskTime</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCTASKTIME($,$,$,$,$,$,$,$,$,$,$,$,$,$,$,$,$,$,$,$);
#2=IFCTASK('0eA6m4fELI9QBIhP3wiLAp',$,$,$,$,$,$,$,$,.T.,$,#1,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-attributes_referencing_an_object_should_pass.ids) - [Sample IFC: 2](testcases/attribute/pass-attributes_referencing_an_object_should_pass.ifc)

## [PASS] Attributes with a select referencing an object should pass

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>DiffuseColour</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCCOLOURRGB($,1.,1.,1.);
#2=IFCCOLOURRGB($,1.,1.,1.);
#3=IFCSURFACESTYLERENDERING(#1,$,#2,$,$,$,$,$,.FLAT.); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-attributes_with_a_select_referencing_an_object_should_pass.ids) - [Sample IFC: 3](testcases/attribute/pass-attributes_with_a_select_referencing_an_object_should_pass.ifc)

## [PASS] Attributes with a select referencing a primitive should pass

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>DiffuseColour</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCCOLOURRGB($,1.,1.,1.);
#2=IFCSURFACESTYLERENDERING(#1,$,IFCNORMALISEDRATIOMEASURE(0.5),$,$,$,$,$,.FLAT.); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-attributes_with_a_select_referencing_a_primitive_should_pass.ids) - [Sample IFC: 2](testcases/attribute/pass-attributes_with_a_select_referencing_a_primitive_should_pass.ifc)

## [FAIL] Inverse attributes cannot be checked and always fail

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>EngagedIn</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCPERSON($,$,$,$,$,$,$,$); /* Testcase */
#2=IFCORGANIZATION($,'Foo',$,$,$);
#3=IFCPERSONANDORGANIZATION(#1,#2,$);
~~~

[Sample IDS](testcases/attribute/fail-inverse_attributes_cannot_be_checked_and_always_fail.ids) - [Sample IFC: 1](testcases/attribute/fail-inverse_attributes_cannot_be_checked_and_always_fail.ifc)

## [FAIL] Derived attributes cannot be checked and always fail

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Dim</simpleValue>
  </name>
</attribute>
~~~

~~~lua
#1=IFCCARTESIANPOINT((0.,0.,0.)); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-derived_attributes_cannot_be_checked_and_always_fail.ids) - [Sample IFC: 1](testcases/attribute/fail-derived_attributes_cannot_be_checked_and_always_fail.ifc)

## [PASS] Attributes should check strings case sensitively 1/2

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
  <value>
    <simpleValue>Foobar</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Foobar',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-attributes_should_check_strings_case_sensitively_1_2.ids) - [Sample IFC: 1](testcases/attribute/pass-attributes_should_check_strings_case_sensitively_1_2.ifc)

## [FAIL] Attributes should check strings case sensitively 2/2

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
  <value>
    <simpleValue>Foobar</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'foobar',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-attributes_should_check_strings_case_sensitively_2_2.ids) - [Sample IFC: 1](testcases/attribute/fail-attributes_should_check_strings_case_sensitively_2_2.ifc)

## [PASS] Non-ascii characters are treated without encoding

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
  <value>
    <simpleValue>♫</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'\X2\266B\X0\',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-non_ascii_characters_are_treated_without_encoding.ids) - [Sample IFC: 1](testcases/attribute/pass-non_ascii_characters_are_treated_without_encoding.ifc)

## [FAIL] Value checks always fail for objects

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>TaskTime</simpleValue>
  </name>
  <value>
    <simpleValue>Foobar</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCTASKTIME($,$,$,$,$,$,$,$,$,$,$,$,$,$,$,$,$,$,$,$);
#2=IFCTASK('0eA6m4fELI9QBIhP3wiLAp',$,$,$,$,$,$,$,$,.F.,$,#1,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-value_checks_always_fail_for_objects.ids) - [Sample IFC: 2](testcases/attribute/fail-value_checks_always_fail_for_objects.ifc)

## [FAIL] Value checks always fail for selects

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>DiffuseColour</simpleValue>
  </name>
  <value>
    <simpleValue>Foobar</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCCOLOURRGB($,1.,1.,1.);
#2=IFCSURFACESTYLERENDERING(#1,$,IFCNORMALISEDRATIOMEASURE(0.5),$,$,$,$,$,.FLAT.); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-value_checks_always_fail_for_selects.ids) - [Sample IFC: 2](testcases/attribute/fail-value_checks_always_fail_for_selects.ifc)

## [FAIL] Value checks always fail for lists

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Coordinates</simpleValue>
  </name>
  <value>
    <simpleValue>Foobar</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCCARTESIANPOINT((0.,0.,0.)); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-value_checks_always_fail_for_lists.ids) - [Sample IFC: 1](testcases/attribute/fail-value_checks_always_fail_for_lists.ifc)

## [PASS] GlobalIds are treated as strings and not expanded

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>GlobalId</simpleValue>
  </name>
  <value>
    <simpleValue>1hqIFTRjfV6AWq_bMtnZwI</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-globalids_are_treated_as_strings_and_not_expanded.ids) - [Sample IFC: 1](testcases/attribute/pass-globalids_are_treated_as_strings_and_not_expanded.ifc)

## [FAIL] IDS does not handle string truncation such as for identifiers

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Identification</simpleValue>
  </name>
  <value>
    <simpleValue>123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345_extra_characters</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCPERSON('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345',$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-ids_does_not_handle_string_truncation_such_as_for_identifiers.ids) - [Sample IFC: 1](testcases/attribute/fail-ids_does_not_handle_string_truncation_such_as_for_identifiers.ifc)

## [PASS] Numeric values are checked using type casting 1/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <simpleValue>42</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(42.,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-numeric_values_are_checked_using_type_casting_1_4.ids) - [Sample IFC: 1](testcases/attribute/pass-numeric_values_are_checked_using_type_casting_1_4.ifc)

## [PASS] Numeric values are checked using type casting 2/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <simpleValue>42.</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(42.,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-numeric_values_are_checked_using_type_casting_2_4.ids) - [Sample IFC: 1](testcases/attribute/pass-numeric_values_are_checked_using_type_casting_2_4.ifc)

## [PASS] Numeric values are checked using type casting 3/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <simpleValue>42.0</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(42.,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-numeric_values_are_checked_using_type_casting_3_4.ids) - [Sample IFC: 1](testcases/attribute/pass-numeric_values_are_checked_using_type_casting_3_4.ifc)

## [FAIL] Numeric values are checked using type casting 4/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <simpleValue>42</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(42.3,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-numeric_values_are_checked_using_type_casting_4_4.ids) - [Sample IFC: 1](testcases/attribute/fail-numeric_values_are_checked_using_type_casting_4_4.ifc)

## [FAIL] Only specifically formatted numbers are allowed 1/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <simpleValue>42,3</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(42.3,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-only_specifically_formatted_numbers_are_allowed_1_4.ids) - [Sample IFC: 1](testcases/attribute/fail-only_specifically_formatted_numbers_are_allowed_1_4.ifc)

## [FAIL] Only specifically formatted numbers are allowed 2/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <simpleValue>123,4.5</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(1234.5,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-only_specifically_formatted_numbers_are_allowed_2_4.ids) - [Sample IFC: 1](testcases/attribute/fail-only_specifically_formatted_numbers_are_allowed_2_4.ifc)

## [PASS] Only specifically formatted numbers are allowed 3/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <simpleValue>1.2345e3</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(1234.5,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-only_specifically_formatted_numbers_are_allowed_3_4.ids) - [Sample IFC: 1](testcases/attribute/pass-only_specifically_formatted_numbers_are_allowed_3_4.ifc)

## [PASS] Only specifically formatted numbers are allowed 4/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <simpleValue>1.2345E3</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(1234.5,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-only_specifically_formatted_numbers_are_allowed_4_4.ids) - [Sample IFC: 1](testcases/attribute/pass-only_specifically_formatted_numbers_are_allowed_4_4.ifc)

## [PASS] Floating point numbers are compared with a 1e-6 tolerance 1/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <simpleValue>42.</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(42.000042,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_1_4.ids) - [Sample IFC: 1](testcases/attribute/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_1_4.ifc)

## [PASS] Floating point numbers are compared with a 1e-6 tolerance 2/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <simpleValue>42.</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(42.000042,$);
#2=IFCSURFACESTYLEREFRACTION(41.999958,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_2_4.ids) - [Sample IFC: 2](testcases/attribute/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_2_4.ifc)

## [FAIL] Floating point numbers are compared with a 1e-6 tolerance 3/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <simpleValue>42.</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(42.000042,$);
#2=IFCSURFACESTYLEREFRACTION(41.999958,$);
#3=IFCSURFACESTYLEREFRACTION(42.000084,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_3_4.ids) - [Sample IFC: 3](testcases/attribute/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_3_4.ifc)

## [FAIL] Floating point numbers are compared with a 1e-6 tolerance 4/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <simpleValue>42.</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(42.000042,$);
#2=IFCSURFACESTYLEREFRACTION(41.999958,$);
#3=IFCSURFACESTYLEREFRACTION(42.000084,$);
#4=IFCSURFACESTYLEREFRACTION(41.999916,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_4_4.ids) - [Sample IFC: 4](testcases/attribute/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_4_4.ifc)

## [PASS] Integers follow the same rules as numbers

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>NumberOfRisers</simpleValue>
  </name>
  <value>
    <simpleValue>42</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSTAIRFLIGHT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,42,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-integers_follow_the_same_rules_as_numbers.ids) - [Sample IFC: 1](testcases/attribute/pass-integers_follow_the_same_rules_as_numbers.ifc)

## [PASS] Integers follow the same rules as numbers 2/2

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>NumberOfRisers</simpleValue>
  </name>
  <value>
    <simpleValue>42.0</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSTAIRFLIGHT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,42,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-integers_follow_the_same_rules_as_numbers_2_2.ids) - [Sample IFC: 1](testcases/attribute/pass-integers_follow_the_same_rules_as_numbers_2_2.ifc)

## [FAIL] Specifying a float when the value is an integer will fail

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>NumberOfRisers</simpleValue>
  </name>
  <value>
    <simpleValue>42.3</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSTAIRFLIGHT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,42,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-specifying_a_float_when_the_value_is_an_integer_will_fail.ids) - [Sample IFC: 1](testcases/attribute/fail-specifying_a_float_when_the_value_is_an_integer_will_fail.ifc)

## [FAIL] Booleans must be specified as uppercase strings 1/3

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>IsMilestone</simpleValue>
  </name>
  <value>
    <simpleValue>TRUE</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCTASK('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$,.F.,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-booleans_must_be_specified_as_uppercase_strings_1_3.ids) - [Sample IFC: 1](testcases/attribute/fail-booleans_must_be_specified_as_uppercase_strings_1_3.ifc)

## [PASS] Booleans must be specified as uppercase strings 2/3

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>IsMilestone</simpleValue>
  </name>
  <value>
    <simpleValue>FALSE</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCTASK('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$,.F.,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-booleans_must_be_specified_as_uppercase_strings_2_3.ids) - [Sample IFC: 1](testcases/attribute/pass-booleans_must_be_specified_as_uppercase_strings_2_3.ifc)

## [FAIL] Booleans must be specified as uppercase strings 2/3

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>IsMilestone</simpleValue>
  </name>
  <value>
    <simpleValue>False</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCTASK('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$,.F.,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-booleans_must_be_specified_as_uppercase_strings_2_3.ids) - [Sample IFC: 1](testcases/attribute/fail-booleans_must_be_specified_as_uppercase_strings_2_3.ifc)

## [PASS] Dates are treated as strings 1/2

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>EditionDate</simpleValue>
  </name>
  <value>
    <simpleValue>2022-01-01</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCCLASSIFICATION($,$,'2022-01-01','Name',$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-dates_are_treated_as_strings_1_2.ids) - [Sample IFC: 1](testcases/attribute/pass-dates_are_treated_as_strings_1_2.ifc)

## [FAIL] Dates are treated as strings 1/2

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>EditionDate</simpleValue>
  </name>
  <value>
    <simpleValue>2022-01-01</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCCLASSIFICATION($,$,'2022-01-01+00:00','Name',$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-dates_are_treated_as_strings_1_2.ids) - [Sample IFC: 1](testcases/attribute/fail-dates_are_treated_as_strings_1_2.ifc)

## [FAIL] Durations are treated as strings 1/2

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>ScheduleDuration</simpleValue>
  </name>
  <value>
    <simpleValue>PT16H</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCCLASSIFICATION($,$,'PT16H','Name',$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-durations_are_treated_as_strings_1_2.ids) - [Sample IFC: 1](testcases/attribute/fail-durations_are_treated_as_strings_1_2.ifc)

## [FAIL] Durations are treated as strings 2/2

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>ScheduleDuration</simpleValue>
  </name>
  <value>
    <simpleValue>PT16H</simpleValue>
  </value>
</attribute>
~~~

~~~lua
#1=IFCCLASSIFICATION($,$,'P2D','Name',$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-durations_are_treated_as_strings_2_2.ids) - [Sample IFC: 1](testcases/attribute/fail-durations_are_treated_as_strings_2_2.ifc)

## [PASS] Name restrictions may be used 1/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <xs:restriction base="xs:string">
      <xs:pattern value=".*Name.*"/>
    </xs:restriction>
  </name>
</attribute>
~~~

~~~lua
#1=IFCMATERIALLAYER($,1.,$,$,$,$,$);
#2=IFCMATERIALLAYERSET((#1),'Foo',$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-name_restrictions_may_be_used_1_4.ids) - [Sample IFC: 2](testcases/attribute/pass-name_restrictions_may_be_used_1_4.ifc)

## [PASS] Name restrictions may be used 2/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <xs:restriction base="xs:string">
      <xs:pattern value=".*Name.*"/>
    </xs:restriction>
  </name>
</attribute>
~~~

~~~lua
#1=IFCMATERIALCONSTITUENTSET('Foo',$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-name_restrictions_may_be_used_2_4.ids) - [Sample IFC: 1](testcases/attribute/pass-name_restrictions_may_be_used_2_4.ifc)

## [FAIL] Name restrictions may be used 3/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <xs:restriction base="xs:string">
      <xs:enumeration value="Name"/>
      <xs:enumeration value="Description"/>
    </xs:restriction>
  </name>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Foo',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-name_restrictions_may_be_used_3_4.ids) - [Sample IFC: 1](testcases/attribute/fail-name_restrictions_may_be_used_3_4.ifc)

## [PASS] Name restrictions may be used 4/4

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <xs:restriction base="xs:string">
      <xs:enumeration value="Name"/>
      <xs:enumeration value="Description"/>
    </xs:restriction>
  </name>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Foo','Bar',$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-name_restrictions_may_be_used_4_4.ids) - [Sample IFC: 1](testcases/attribute/pass-name_restrictions_may_be_used_4_4.ifc)

## [PASS] Value restrictions may be used 1/3

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:string">
      <xs:enumeration value="Foo"/>
      <xs:enumeration value="Bar"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Foo',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-value_restrictions_may_be_used_1_3.ids) - [Sample IFC: 1](testcases/attribute/pass-value_restrictions_may_be_used_1_3.ifc)

## [PASS] Value restrictions may be used 2/3

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:string">
      <xs:enumeration value="Foo"/>
      <xs:enumeration value="Bar"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Bar',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-value_restrictions_may_be_used_2_3.ids) - [Sample IFC: 1](testcases/attribute/pass-value_restrictions_may_be_used_2_3.ifc)

## [FAIL] Value restrictions may be used 3/3

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:string">
      <xs:enumeration value="Foo"/>
      <xs:enumeration value="Bar"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,'Foobar',$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/fail-value_restrictions_may_be_used_3_3.ids) - [Sample IFC: 1](testcases/attribute/fail-value_restrictions_may_be_used_3_3.ifc)

## [FAIL] Attributes are not inherited by the occurrence

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>Name</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:string">
      <xs:enumeration value="Foo"/>
      <xs:enumeration value="Bar"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCWALL('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,$); /* Testcase */
#2=IFCWALLTYPE('1hqIFTRjfV6AWq_bMtnZwI',$,$,'Foobar',$,$,$,$,$,.ELEMENTEDWALL.);
#3=IFCRELDEFINESBYTYPE('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,(#1),#2);
~~~

[Sample IDS](testcases/attribute/fail-attributes_are_not_inherited_by_the_occurrence.ids) - [Sample IFC: 1](testcases/attribute/fail-attributes_are_not_inherited_by_the_occurrence.ifc)

## [PASS] Typecast checking may also occur within enumeration restrictions

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:string">
      <xs:enumeration value="42"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(42.,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-typecast_checking_may_also_occur_within_enumeration_restrictions.ids) - [Sample IFC: 1](testcases/attribute/pass-typecast_checking_may_also_occur_within_enumeration_restrictions.ifc)

## [PASS] Strict numeric checking may be done with a bounds restriction

~~~xml
<attribute minOccurs="1" maxOccurs="1">
  <name>
    <simpleValue>RefractionIndex</simpleValue>
  </name>
  <value>
    <xs:restriction base="xs:decimal">
      <xs:minInclusive value="42" fixed="false"/>
      <xs:maxInclusive value="42" fixed="false"/>
    </xs:restriction>
  </value>
</attribute>
~~~

~~~lua
#1=IFCSURFACESTYLEREFRACTION(42.,$); /* Testcase */
~~~

[Sample IDS](testcases/attribute/pass-strict_numeric_checking_may_be_done_with_a_bounds_restriction.ids) - [Sample IFC: 1](testcases/attribute/pass-strict_numeric_checking_may_be_done_with_a_bounds_restriction.ifc)

