# Documentation test cases

## attribute

### A prohibited facet returns the opposite of a required facet

``` ids attribute/fail-a_prohibited_facet_returns_the_opposite_of_a_required_facet.ids
A prohibited facet returns the opposite of a required facet
IFC2X3 IFC4 IFC4X3
Entity: ''IFCWALL''
Requirements:
Attribute: Prohibited,''Name''
```

### A required facet checks all parameters as normal

``` ids attribute/pass-a_required_facet_checks_all_parameters_as_normal.ids
A required facet checks all parameters as normal
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name''
```

### An optional facet always passes regardless of outcome 1/2

``` ids attribute/pass-an_optional_facet_always_passes_regardless_of_outcome_1_2.ids
An optional facet always passes regardless of outcome 1/2
Entity: ''IFCWALL''
Requirements:
Attribute: Optional,''Name''
```

### An optional facet always passes regardless of outcome 2/2

``` ids attribute/pass-an_optional_facet_always_passes_regardless_of_outcome_2_2.ids
An optional facet always passes regardless of outcome 2/2
Entity: ''IFCWALL''
Requirements:
Attribute: Optional,''ActingRole''
```

### Attributes are not inherited by the occurrence

``` ids attribute/fail-attributes_are_not_inherited_by_the_occurrence.ids
Attributes are not inherited by the occurrence
Entity: ''IFCWALL''
Requirements:
Attribute: ''Description'',''Foobar''
```

### Attributes referencing an object should pass

``` ids attribute/pass-attributes_referencing_an_object_should_pass.ids
Attributes referencing an object should pass
IFC4
Entity: ''IFCTASK''
Requirements:
Attribute: ''TaskTime''
```

### Attributes should check strings case sensitively 1/2

``` ids attribute/pass-attributes_should_check_strings_case_sensitively_1_2.ids
Attributes should check strings case sensitively 1/2
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',''Foobar''
```

### Attributes should check strings case sensitively 2/2

``` ids attribute/fail-attributes_should_check_strings_case_sensitively_2_2.ids
Attributes should check strings case sensitively 2/2
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',''Foobar''
```

### Attributes with a boolean false should pass

``` ids attribute/pass-attributes_with_a_boolean_false_should_pass.ids
Attributes with a boolean false should pass
IFC4
Entity: ''IFCTASKTIME''
Requirements:
Attribute: ''IsCritical''
```

### Attributes with a boolean true should pass

``` ids attribute/pass-attributes_with_a_boolean_true_should_pass.ids
Attributes with a boolean true should pass
IFC4
Entity: ''IFCTASKTIME''
Requirements:
Attribute: ''IsCritical''
```

### Attributes with a logical unknown always fail

``` ids attribute/fail-attributes_with_a_logical_unknown_always_fail.ids
Attributes with a logical unknown always fail
Entity: ''IFCPRESENTATIONLAYERWITHSTYLE''
Requirements:
Attribute: ''LayerOn''
```

### Attributes with a select referencing a primitive should pass

``` ids attribute/pass-attributes_with_a_select_referencing_a_primitive_should_pass.ids
Attributes with a select referencing a primitive should pass
Entity: ''IFCSURFACESTYLERENDERING''
Requirements:
Attribute: ''DiffuseColour''
```

### Attributes with a select referencing an object should pass

``` ids attribute/pass-attributes_with_a_select_referencing_an_object_should_pass.ids
Attributes with a select referencing an object should pass
Entity: ''IFCSURFACESTYLERENDERING''
Requirements:
Attribute: ''DiffuseColour''
```

### Attributes with a string value should pass

``` ids attribute/pass-attributes_with_a_string_value_should_pass.ids
Attributes with a string value should pass
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name''
```

### Attributes with a zero duration should pass

``` ids attribute/pass-attributes_with_a_zero_duration_should_pass.ids
Attributes with a zero duration should pass
IFC4
Entity: ''IFCTASKTIME''
Requirements:
Attribute: ''ScheduleDuration''
```

### Attributes with a zero number have meaning and should pass

``` ids attribute/pass-attributes_with_a_zero_number_have_meaning_and_should_pass.ids
Attributes with a zero number have meaning and should pass
Entity: ''IFCQUANTITYCOUNT''
Requirements:
Attribute: ''CountValue''
```

### Attributes with an empty list always fail

``` ids attribute/fail-attributes_with_an_empty_list_always_fail.ids
Attributes with an empty list always fail
Entity: ''IFCRELCONNECTSPATHELEMENTS''
Requirements:
Attribute: ''RelatingPriorities''
```

### Attributes with an empty set always fail

``` ids attribute/fail-attributes_with_an_empty_set_always_fail.ids
Attributes with an empty set always fail
Entity: ''IFCPRESENTATIONLAYERWITHSTYLE''
Requirements:
Attribute: ''LayerStyles''
```

### Attributes with empty strings always fail

``` ids attribute/fail-attributes_with_empty_strings_always_fail.ids
Attributes with empty strings always fail
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name''
```

### Attributes with null values always fail

``` ids attribute/fail-attributes_with_null_values_always_fail.ids
Attributes with null values always fail
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name''
```

### Booleans must be specified as uppercase strings 1/3

``` ids attribute/fail-booleans_must_be_specified_as_uppercase_strings_1_3.ids
Booleans must be specified as uppercase strings 1/3
Entity: ''IFCTASK''
Requirements:
Attribute: ''IsMilestone'',''TRUE''
```

### Booleans must be specified as uppercase strings 2/3

``` ids attribute/fail-booleans_must_be_specified_as_uppercase_strings_2_3.ids
Booleans must be specified as uppercase strings 2/3
Entity: ''IFCTASK''
Requirements:
Attribute: ''IsMilestone'',''False''
```

### Booleans must be specified as uppercase strings 2/3

``` ids attribute/pass-booleans_must_be_specified_as_uppercase_strings_2_3.ids
Booleans must be specified as uppercase strings 2/3
Entity: ''IFCTASK''
Requirements:
Attribute: ''IsMilestone'',''FALSE''
```

### Dates are treated as strings 1/2

``` ids attribute/fail-dates_are_treated_as_strings_1_2.ids
Dates are treated as strings 1/2
Entity: ''IFCCLASSIFICATION''
Requirements:
Attribute: ''EditionDate'',''2022-01-01''
```

### Dates are treated as strings 1/2

``` ids attribute/pass-dates_are_treated_as_strings_1_2.ids
Dates are treated as strings 1/2
Entity: ''IFCCLASSIFICATION''
Requirements:
Attribute: ''EditionDate'',''2022-01-01''
```

### Derived attributes cannot be checked and always fail

``` ids attribute/fail-derived_attributes_cannot_be_checked_and_always_fail.ids
Derived attributes cannot be checked and always fail
Entity: ''IFCCARTESIANPOINT''
Requirements:
Attribute: ''Dim''
```

### Durations are treated as strings 1/2

``` ids attribute/pass-durations_are_treated_as_strings_1_2.ids
Durations are treated as strings 1/2
IFC4
Entity: ''IFCTASKTIME''
Requirements:
Attribute: ''ScheduleDuration'',''PT16H''
```

### Durations are treated as strings 2/2

``` ids attribute/fail-durations_are_treated_as_strings_2_2.ids
Durations are treated as strings 2/2
Entity: ''IFCTASKTIME''
Requirements:
Attribute: ''ScheduleDuration'',''PT16H''
```

### Floating point numbers are compared with a 1e-6 tolerance 1/4

``` ids attribute/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_1_4.ids
Floating point numbers are compared with a 1e-6 tolerance 1/4
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',''42.''
```

### Floating point numbers are compared with a 1e-6 tolerance 2/4

``` ids attribute/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_2_4.ids
Floating point numbers are compared with a 1e-6 tolerance 2/4
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',''42.''
```

### Floating point numbers are compared with a 1e-6 tolerance 3/4

``` ids attribute/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_3_4.ids
Floating point numbers are compared with a 1e-6 tolerance 3/4
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',''42.''
```

### Floating point numbers are compared with a 1e-6 tolerance 4/4

``` ids attribute/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_4_4.ids
Floating point numbers are compared with a 1e-6 tolerance 4/4
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',''42.''
```

### GlobalIds are treated as strings and not expanded

``` ids attribute/pass-globalids_are_treated_as_strings_and_not_expanded.ids
GlobalIds are treated as strings and not expanded
Entity: ''IFCWALL''
Requirements:
Attribute: ''GlobalId'',''1hqIFTRjfV6AWq_bMtnZwI''
```

### IDS does not handle string truncation such as for identifiers

``` ids attribute/fail-ids_does_not_handle_string_truncation_such_as_for_identifiers.ids
IDS does not handle string truncation such as for identifiers
Entity: ''IFCPERSON''
Requirements:
Attribute: ''Identification'',''123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345_extra_characters''
```

### Integers follow the same rules as numbers

``` ids attribute/pass-integers_follow_the_same_rules_as_numbers.ids
Integers follow the same rules as numbers
IFC4
Entity: ''IFCSTAIRFLIGHT''
Requirements:
Attribute: ''NumberOfRisers'',''42''
```

### Integers follow the same rules as numbers 2/2

``` ids attribute/pass-integers_follow_the_same_rules_as_numbers_2_2.ids
Integers follow the same rules as numbers 2/2
IFC4
Entity: ''IFCSTAIRFLIGHT''
Requirements:
Attribute: ''NumberOfRisers'',''42.0''
```

### Invalid attribute names always fail

``` ids attribute/fail-invalid_attribute_names_always_fail.ids
Invalid attribute names always fail
Entity: ''IFCWALL''
Requirements:
Attribute: ''ActingRole''
```

### Inverse attributes cannot be checked and always fail

``` ids attribute/fail-inverse_attributes_cannot_be_checked_and_always_fail.ids
Inverse attributes cannot be checked and always fail
Entity: ''IFCPERSON''
Requirements:
Attribute: ''EngagedIn''
```

### Name restrictions will match any result 1/3

``` ids attribute/pass-name_restrictions_will_match_any_result_1_3.ids
Name restrictions will match any result 1/3
Entity: ''IFCMATERIALLAYERSET''
Requirements:
Attribute: Pattern(''.*Name.*'')
```

### Name restrictions will match any result 2/3

``` ids attribute/pass-name_restrictions_will_match_any_result_2_3.ids
Name restrictions will match any result 2/3
Entity: ''IFCWALL''
Requirements:
Attribute: Enumeration(''Name'',''Description'')
```

### Name restrictions will match any result 3/3

``` ids attribute/pass-name_restrictions_will_match_any_result_3_3.ids
Name restrictions will match any result 3/3
Entity: ''IFCWALL''
Requirements:
Attribute: Enumeration(''Name'',''Description'')
```

### Non-ascii characters are treated without encoding

``` ids attribute/pass-non_ascii_characters_are_treated_without_encoding.ids
Non-ascii characters are treated without encoding
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',''♫Don'tÄrgerhôtelЊет''
```

### Numeric values are checked using type casting 1/4

``` ids attribute/pass-numeric_values_are_checked_using_type_casting_1_4.ids
Numeric values are checked using type casting 1/4
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',''42''
```

### Numeric values are checked using type casting 2/4

``` ids attribute/pass-numeric_values_are_checked_using_type_casting_2_4.ids
Numeric values are checked using type casting 2/4
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',''42.''
```

### Numeric values are checked using type casting 3/4

``` ids attribute/pass-numeric_values_are_checked_using_type_casting_3_4.ids
Numeric values are checked using type casting 3/4
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',''42.0''
```

### Numeric values are checked using type casting 4/4

``` ids attribute/fail-numeric_values_are_checked_using_type_casting_4_4.ids
Numeric values are checked using type casting 4/4
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',''42''
```

### Only specifically formatted numbers are allowed 1/4

``` ids attribute/fail-only_specifically_formatted_numbers_are_allowed_1_4.ids
Only specifically formatted numbers are allowed 1/4
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',''42,3''
```

### Only specifically formatted numbers are allowed 2/4

``` ids attribute/fail-only_specifically_formatted_numbers_are_allowed_2_4.ids
Only specifically formatted numbers are allowed 2/4
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',''123,4.5''
```

### Only specifically formatted numbers are allowed 3/4

``` ids attribute/pass-only_specifically_formatted_numbers_are_allowed_3_4.ids
Only specifically formatted numbers are allowed 3/4
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',''1.2345e3''
```

### Only specifically formatted numbers are allowed 4/4

``` ids attribute/pass-only_specifically_formatted_numbers_are_allowed_4_4.ids
Only specifically formatted numbers are allowed 4/4
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',''1.2345E3''
```

### Specifying a float when the value is an integer will fail

``` ids attribute/fail-specifying_a_float_when_the_value_is_an_integer_will_fail.ids
Specifying a float when the value is an integer will fail
Entity: ''IFCSTAIRFLIGHT''
Requirements:
Attribute: ''NumberOfRisers'',''42.3''
```

### Strict numeric checking may be done with a bounds restriction

``` ids attribute/pass-strict_numeric_checking_may_be_done_with_a_bounds_restriction.ids
Strict numeric checking may be done with a bounds restriction
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',xs:decimal MinInclusive(''42'') MaxInclusive(''42'')
```

### Typecast checking may also occur within enumeration restrictions

``` ids attribute/pass-typecast_checking_may_also_occur_within_enumeration_restrictions.ids
Typecast checking may also occur within enumeration restrictions
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',Enumeration(''42'',''43'')
```

### Value checks always fail for lists

``` ids attribute/fail-value_checks_always_fail_for_lists.ids
Value checks always fail for lists
Entity: ''IFCCARTESIANPOINT''
Requirements:
Attribute: ''Coordinates'',''Foobar''
```

### Value checks always fail for objects

``` ids attribute/fail-value_checks_always_fail_for_objects.ids
Value checks always fail for objects
Entity: ''IFCTASK''
Requirements:
Attribute: ''TaskTime'',''Foobar''
```

### Value checks always fail for selects

``` ids attribute/fail-value_checks_always_fail_for_selects.ids
Value checks always fail for selects
Entity: ''IFCSURFACESTYLERENDERING''
Requirements:
Attribute: ''DiffuseColour'',''Foobar''
```

### Value restrictions may be used 1/3

``` ids attribute/pass-value_restrictions_may_be_used_1_3.ids
Value restrictions may be used 1/3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',Enumeration(''Foo'',''Bar'')
```

### Value restrictions may be used 2/3

``` ids attribute/pass-value_restrictions_may_be_used_2_3.ids
Value restrictions may be used 2/3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',Enumeration(''Foo'',''Bar'')
```

### Value restrictions may be used 3/3

``` ids attribute/fail-value_restrictions_may_be_used_3_3.ids
Value restrictions may be used 3/3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',Enumeration(''Foo'',''Bar'')
```

## classification

### A classification facet with no data matches any classification 1/2

``` ids classification/fail-a_classification_facet_with_no_data_matches_any_classification_1_2.ids
A classification facet with no data matches any classification 1/2
Entity: ''IFCWALL''
Requirements:
Classification: Pattern(''.*'')
```

### A classification facet with no data matches any classification 2/2

``` ids classification/pass-a_classification_facet_with_no_data_matches_any_classification_2_2.ids
A classification facet with no data matches any classification 2/2
Entity: ''IFCSLAB''
Requirements:
Classification: Pattern(''.*'')
```

### A prohibited facet returns the opposite of a required facet

``` ids classification/fail-a_prohibited_facet_returns_the_opposite_of_a_required_facet.ids
A prohibited facet returns the opposite of a required facet
Entity: ''IFCSLAB''
Requirements:
Classification: Prohibited,Pattern(''.*'')
```

### A required facet checks all parameters as normal

``` ids classification/pass-a_required_facet_checks_all_parameters_as_normal.ids
A required facet checks all parameters as normal
Entity: ''IFCSLAB''
Requirements:
Classification: Pattern(''.*'')
```

### An optional facet always passes regardless of outcome 1/2

``` ids classification/pass-an_optional_facet_always_passes_regardless_of_outcome_1_2.ids
An optional facet always passes regardless of outcome 1/2
Entity: ''IFCWALL''
Requirements:
Classification: Optional,Pattern(''.*'')
```

### An optional facet always passes regardless of outcome 2/2

``` ids classification/pass-an_optional_facet_always_passes_regardless_of_outcome_2_2.ids
An optional facet always passes regardless of outcome 2/2
Entity: ''IFCSLAB''
Requirements:
Classification: Optional,Pattern(''.*'')
```

### Both system and value must match (all, not any) if specified 1/2

``` ids classification/pass-both_system_and_value_must_match__all__not_any__if_specified_1_2.ids
Both system and value must match (all, not any) if specified 1/2
Entity: ''IFCSLAB''
Requirements:
Classification: ''Foobar'',''1''
```

### Both system and value must match (all, not any) if specified 2/2

``` ids classification/fail-both_system_and_value_must_match__all__not_any__if_specified_2_2.ids
Both system and value must match (all, not any) if specified 2/2
Entity: ''IFCCOLUMN''
Requirements:
Classification: ''Foobar'',''1''
```

### Non-rooted resources that have external classification references should also pass

TODO: This is suspended until the auditing tool is completed.

``` suspended ids classification/pass-non_rooted_resources_that_have_external_classification_references_should_also_pass.ids
Non-rooted resources that have external classification references should also pass
Entity: ''IFCMATERIAL''
Requirements:
Classification: Pattern(''.*''),''1''
```

### Occurrences override the type classification per system 1/3

``` ids classification/pass-occurrences_override_the_type_classification_per_system_1_3.ids
Occurrences override the type classification per system 1/3
Entity: ''IFCWALL''
Requirements:
Classification: Pattern(''.*''),''11''
```

### Occurrences override the type classification per system 2/3

``` ids classification/fail-occurrences_override_the_type_classification_per_system_2_3.ids
Occurrences override the type classification per system 2/3
Entity: ''IFCWALL''
Requirements:
Classification: Pattern(''.*''),''22''
```

### Occurrences override the type classification per system 3/3

``` ids classification/pass-occurrences_override_the_type_classification_per_system_3_3.ids
Occurrences override the type classification per system 3/3
Entity: ''IFCWALL''
Requirements:
Classification: Pattern(''.*''),''X''
```

### Restrictions can be used for systems 1/2

``` ids classification/fail-restrictions_can_be_used_for_systems_1_2.ids
Restrictions can be used for systems 1/2
Entity: ''IFCWALL''
Requirements:
Classification: Pattern(''Foo.*'')
```

### Restrictions can be used for systems 2/2

``` ids classification/pass-restrictions_can_be_used_for_systems_2_2.ids
Restrictions can be used for systems 2/2
Entity: ''IFCSLAB''
Requirements:
Classification: Pattern(''Foo.*'')
```

### Restrictions can be used for values 1/3

``` ids classification/pass-restrictions_can_be_used_for_values_1_3.ids
Restrictions can be used for values 1/3
Entity: ''IFCSLAB''
Requirements:
Classification: Pattern(''.*''),Pattern(''1.*'')
```

### Restrictions can be used for values 2/3

``` ids classification/pass-restrictions_can_be_used_for_values_2_3.ids
Restrictions can be used for values 2/3
Entity: ''IFCCOLUMN''
Requirements:
Classification: Pattern(''.*''),Pattern(''1.*'')
```

### Restrictions can be used for values 3/3

``` ids classification/fail-restrictions_can_be_used_for_values_3_3.ids
Restrictions can be used for values 3/3
Entity: ''IFCBEAM''
Requirements:
Classification: Pattern(''.*''),Pattern(''1.*'')
```

### Systems should match exactly 1/5

``` ids classification/pass-systems_should_match_exactly_1_5.ids
Systems should match exactly 1/5
Entity: ''IFCPROJECT''
Requirements:
Classification: ''Foobar''
```

### Systems should match exactly 2/5

``` ids classification/fail-systems_should_match_exactly_2_5.ids
Systems should match exactly 2/5
Entity: ''IFCWALL''
Requirements:
Classification: ''Foobar''
```

### Systems should match exactly 3/5

``` ids classification/pass-systems_should_match_exactly_3_5.ids
Systems should match exactly 3/5
Entity: ''IFCSLAB''
Requirements:
Classification: ''Foobar''
```

### Systems should match exactly 4/5

``` ids classification/pass-systems_should_match_exactly_4_5.ids
Systems should match exactly 4/5
Entity: ''IFCCOLUMN''
Requirements:
Classification: ''Foobar''
```

### Systems should match exactly 5/5

``` ids classification/pass-systems_should_match_exactly_5_5.ids
Systems should match exactly 5/5
Entity: ''IFCBEAM''
Requirements:
Classification: ''Foobar''
```

### Values match subreferences if full classifications are used (e.g. EF_25_10 should match EF_25_10_25, EF_25_10_30, etc)

``` ids classification/pass-values_match_subreferences_if_full_classifications_are_used__e_g__ef_25_10_should_match_ef_25_10_25__ef_25_10_30__etc_.ids
Values match subreferences if full classifications are used (e.g. EF_25_10 should match EF_25_10_25, EF_25_10_30, etc)
Entity: ''IFCBEAM''
Requirements:
Classification: Pattern(''.*''),''2''
```

### Values should match exactly if lightweight classifications are used

``` ids classification/pass-values_should_match_exactly_if_lightweight_classifications_are_used.ids
Values should match exactly if lightweight classifications are used
Entity: ''IFCSLAB''
Requirements:
Classification: Pattern(''.*''),''1''
```

## entity

### A matching entity should pass

``` ids entity/pass-a_matching_entity_should_pass.ids
A matching entity should pass
Entity: ''IFCWALL''
Requirements:
Entity: ''IFCWALL''
```

### A matching predefined type should pass

``` ids entity/pass-a_matching_predefined_type_should_pass.ids
A matching predefined type should pass
IFC4
Entity: ''IFCWALL''
Requirements:
Entity: ''IFCWALL'',''SOLIDWALL''
```

### A null predefined type should always fail a specified predefined types

``` ids entity/fail-a_null_predefined_type_should_always_fail_a_specified_predefined_types.ids
A null predefined type should always fail a specified predefined types
Entity: ''IFCWALL''
Requirements:
Entity: ''IFCWALL'',''SOLIDWALL''
```

### A predefined type from an enumeration must be uppercase

``` ids entity/fail-a_predefined_type_from_an_enumeration_must_be_uppercase.ids
A predefined type from an enumeration must be uppercase
Entity: ''IFCWALL''
Requirements:
Entity: ''IFCWALL'',''solidwall''
```

### A predefined type may specify a user-defined element type

``` ids entity/pass-a_predefined_type_may_specify_a_user_defined_element_type.ids
A predefined type may specify a user-defined element type
Entity: ''IFCWALLTYPE''
Requirements:
Entity: ''IFCWALLTYPE'',''WALDO''
```

### A predefined type may specify a user-defined object type

This custom subType should be allowed, if custom. 

``` suspended ids entity/pass-a_predefined_type_may_specify_a_user_defined_object_type.ids
A predefined type may specify a user-defined object type
Entity: ''IFCWALL''
Requirements:
Entity: ''IFCWALL'',''WALDO''
```

### A predefined type may specify a user-defined process type

TODO: Suspended

``` ids entity/pass-a_predefined_type_may_specify_a_user_defined_process_type.ids
A predefined type may specify a user-defined process type
IFC4
Entity: ''IFCTASKTYPE''
Requirements:
Entity: ''IFCTASKTYPE'',''TASKY''
```

### A predefined type must always specify a meaningful type, not USERDEFINED itself

Suspended TODO: the group agreed to allow userdefined as an option too.

``` Suspended ids entity/fail-a_predefined_type_must_always_specify_a_meaningful_type__not_userdefined_itself.ids
A predefined type must always specify a meaningful type, not USERDEFINED itself
Entity: ''IFCWALL''
Requirements:
Entity: ''IFCWALL'',''USERDEFINED''
```

### An entity not matching a specified predefined type will fail

``` ids entity/fail-an_entity_not_matching_a_specified_predefined_type_will_fail.ids
An entity not matching a specified predefined type will fail
Entity: ''IFCWALL''
Requirements:
Entity: ''IFCWALL'',''SOLIDWALL''
```

### An entity not matching the specified class should fail

``` ids entity/fail-an_entity_not_matching_the_specified_class_should_fail.ids
An entity not matching the specified class should fail
Entity: ''IFCSLAB''
Requirements:
Entity: ''IFCWALL''
```

### An matching entity should pass regardless of predefined type

``` ids entity/pass-an_matching_entity_should_pass_regardless_of_predefined_type.ids
An matching entity should pass regardless of predefined type
Entity: ''IFCWALL''
Requirements:
Entity: ''IFCWALL''
```

### Entities can be specified as a XSD regex pattern 1/2

``` ids entity/fail-entities_can_be_specified_as_a_xsd_regex_pattern_1_2.ids
Entities can be specified as a XSD regex pattern 1/2
Entity: ''IFCWALL''
Requirements:
Entity: Pattern(''IFC.*TYPE'')
```

### Entities can be specified as a XSD regex pattern 2/2

``` ids entity/pass-entities_can_be_specified_as_a_xsd_regex_pattern_2_2.ids
Entities can be specified as a XSD regex pattern 2/2
Entity: ''IFCWALLTYPE''
Requirements:
Entity: Pattern(''IFC.*TYPE'')
```

### Entities can be specified as an enumeration 1/3

``` ids entity/pass-entities_can_be_specified_as_an_enumeration_1_3.ids
Entities can be specified as an enumeration 1/3
Entity: ''IFCWALL''
Requirements:
Entity: Enumeration(''IFCWALL'',''IFCSLAB'')
```

### Entities can be specified as an enumeration 2/3

``` ids entity/pass-entities_can_be_specified_as_an_enumeration_2_3.ids
Entities can be specified as an enumeration 2/3
Entity: ''IFCSLAB''
Requirements:
Entity: Enumeration(''IFCWALL'',''IFCSLAB'')
```

### Entities can be specified as an enumeration 3/3

``` ids entity/fail-entities_can_be_specified_as_an_enumeration_3_3.ids
Entities can be specified as an enumeration 3/3
Entity: ''IFCBEAM''
Requirements:
Entity: Enumeration(''IFCWALL'',''IFCSLAB'')
```

### Entities must be specified as uppercase strings

``` ids entity/fail-entities_must_be_specified_as_uppercase_strings.ids
Entities must be specified as uppercase strings
Entity: ''IFCWALL''
Requirements:
Entity: ''IfcWall''
```

### Inherited predefined types should pass

``` ids entity/pass-inherited_predefined_types_should_pass.ids
Inherited predefined types should pass
Entity: ''IFCWALL''
Requirements:
Entity: ''IFCWALL'',''X''
```

### Invalid entities always fail

``` ids entity/fail-invalid_entities_always_fail.ids
Invalid entities always fail
Entity: ''IFCWALL''
Requirements:
Entity: ''IFCRABBIT''
```

### Overridden predefined types should pass

``` ids entity/pass-overridden_predefined_types_should_pass.ids
Overridden predefined types should pass
Entity: ''IFCWALL''
Requirements:
Entity: ''IFCWALL'',''X''
```

### Restrictions an be specified for the predefined type 1/3

``` ids entity/pass-restrictions_an_be_specified_for_the_predefined_type_1_3.ids
Restrictions an be specified for the predefined type 1/3
Entity: ''IFCWALL''
Requirements:
Entity: ''IFCWALL'',Pattern(''FOO.*'')
```

### Restrictions an be specified for the predefined type 2/3

``` ids entity/pass-restrictions_an_be_specified_for_the_predefined_type_2_3.ids
Restrictions an be specified for the predefined type 2/3
Entity: ''IFCWALL''
Requirements:
Entity: ''IFCWALL'',Pattern(''FOO.*'')
```

### Restrictions an be specified for the predefined type 3/3

``` ids entity/fail-restrictions_an_be_specified_for_the_predefined_type_3_3.ids
Restrictions an be specified for the predefined type 3/3
Entity: ''IFCWALL''
Requirements:
Entity: ''IFCWALL'',Pattern(''FOO.*'')
```

### Subclasses are not considered as matching

``` ids entity/fail-subclasses_are_not_considered_as_matching.ids
Subclasses are not considered as matching
Entity: ''IFCWALLSTANDARDCASE''
Requirements:
Entity: ''IFCWALL''
```

### User-defined types are checked case sensitively

``` ids entity/fail-user_defined_types_are_checked_case_sensitively.ids
User-defined types are checked case sensitively
Entity: ''IFCWALL''
Requirements:
Entity: ''IFCWALL'',''WALDO''
```

## ids

### A minimal ids can check a minimal ifc (1/2)

``` ids ids/fail-a_minimal_ids_can_check_a_minimal_ifc_1_2.ids
A minimal ids can check a minimal ifc (1/2)
Optional
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',''Waldo''
```

### A minimal ids can check a minimal ifc (2/2)

``` ids ids/pass-a_minimal_ids_can_check_a_minimal_ifc_2_2.ids
A minimal ids can check a minimal ifc (2/2)
Optional
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',''Waldo''
```

### A prohibited specification and a prohibited facet results in a double negative

``` ids ids/pass-a_prohibited_specification_and_a_prohibited_facet_results_in_a_double_negative.ids
A prohibited specification and a prohibited facet results in a double negative
Prohibited
IFC2X3
Entity: ''IFCWALL''
Requirements:
Attribute: Prohibited,''Name'',''Waldo''
Attribute: Prohibited,''Description'',''Foobar''
```

### A specification passes only if all requirements pass (1/2)

``` ids ids/fail-a_specification_passes_only_if_all_requirements_pass_1_2.ids
A specification passes only if all requirements pass (1/2)
Optional
IFC2X3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',''Waldo''
Attribute: ''Description'',''Foobar''
```

### A specification passes only if all requirements pass (2/2)

``` ids ids/pass-a_specification_passes_only_if_all_requirements_pass_2_2.ids
A specification passes only if all requirements pass (2/2)
Optional
IFC2X3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',''Waldo''
Attribute: ''Description'',''Foobar''
```

### Multiple specifications are independent of one another

``` ids ids/pass-multiple_specifications_are_independent_of_one_another.ids
Multiple specifications are independent of one another
Prohibited
IFC2X3
Entity: ''IFCWALL''
Requirements:
Attribute: Prohibited,''Name'',''Waldo''
Attribute: Prohibited,''Description'',''Foobar''
```

### Optional specifications may still pass if nothing is applicable

``` ids ids/pass-optional_specifications_may_still_pass_if_nothing_is_applicable.ids
Optional specifications may still pass if nothing is applicable
Optional
IFC2X3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',''Waldo''
```

### Prohibited specifications fail if at least one entity passes all requirements (1/3)

``` ids ids/pass-prohibited_specifications_fail_if_at_least_one_entity_passes_all_requirements_1_3.ids
Prohibited specifications fail if at least one entity passes all requirements (1/3)
Prohibited
IFC2X3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',''Waldo''
```

### Prohibited specifications fail if at least one entity passes all requirements (2/3)

``` ids ids/pass-prohibited_specifications_fail_if_at_least_one_entity_passes_all_requirements_2_3.ids
Prohibited specifications fail if at least one entity passes all requirements (2/3)
Prohibited
IFC2X3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',''Waldo''
```

### Prohibited specifications fail if at least one entity passes all requirements (3/3)

``` ids ids/fail-prohibited_specifications_fail_if_at_least_one_entity_passes_all_requirements_3_3.ids
Prohibited specifications fail if at least one entity passes all requirements (3/3)
Prohibited
IFC2X3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',''Waldo''
```

### Required specifications need at least one applicable entity (1/2)

``` ids ids/pass-required_specifications_need_at_least_one_applicable_entity_1_2.ids
Required specifications need at least one applicable entity (1/2)
IFC2X3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',''Waldo''
```

### Required specifications need at least one applicable entity (2/2)

``` ids ids/fail-required_specifications_need_at_least_one_applicable_entity_2_2.ids
Required specifications need at least one applicable entity (2/2)
IFC2X3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',''Waldo''
```

### Specification optionality and facet optionality can be combined

``` ids ids/pass-specification_optionality_and_facet_optionality_can_be_combined.ids
Specification optionality and facet optionality can be combined
Optional
IFC2X3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',''Waldo''
Attribute: Optional,''Description'',''Foobar''
```

### Specification version is purely metadata and does not impact pass or fail result

``` ids ids/pass-specification_version_is_purely_metadata_and_does_not_impact_pass_or_fail_result.ids
Specification version is purely metadata and does not impact pass or fail result
Optional
IFC2X3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',''Waldo''
```

## material

### A constituent set with no data will fail a value check

``` ids material/fail-a_constituent_set_with_no_data_will_fail_a_value_check.ids
A constituent set with no data will fail a value check
Entity: ''IFCWALL''
Requirements:
Material: ''Foo''
```

### A material category may pass the value check

``` ids material/pass-a_material_category_may_pass_the_value_check.ids
A material category may pass the value check
Entity: ''IFCWALL''
Requirements:
Material: ''Foo''
```

### A material list with no data will fail a value check

``` ids material/fail-a_material_list_with_no_data_will_fail_a_value_check.ids
A material list with no data will fail a value check
Entity: ''IfcWall''
Requirements:
Material: ''Foo''
```

### A material name may pass the value check

``` ids material/pass-a_material_name_may_pass_the_value_check.ids
A material name may pass the value check
Entity: ''IFCWALL''
Requirements:
Material: ''Foo''
```

### A prohibited facet returns the opposite of a required facet

``` ids material/fail-a_prohibited_facet_returns_the_opposite_of_a_required_facet.ids
A prohibited facet returns the opposite of a required facet
Entity: ''IFCWALL''
Requirements:
Material: Prohibited,
```

### A required facet checks all parameters as normal

``` ids material/pass-a_required_facet_checks_all_parameters_as_normal.ids
A required facet checks all parameters as normal
Entity: ''IFCWALL''
Requirements:
Material: 
```

### An optional facet always passes regardless of outcome 1/2

``` ids material/pass-an_optional_facet_always_passes_regardless_of_outcome_1_2.ids
An optional facet always passes regardless of outcome 1/2
Entity: ''IFCWALL''
Requirements:
Material: Optional,''Foo''
```

### Any constituent Category in a constituent set will pass a value check

``` ids material/pass-any_constituent_category_in_a_constituent_set_will_pass_a_value_check.ids
Any constituent Category in a constituent set will pass a value check
Entity: ''IFCWALL''
Requirements:
Material: ''Foo''
```

### Any constituent Name in a constituent set will pass a value check

``` ids material/pass-any_constituent_name_in_a_constituent_set_will_pass_a_value_check.ids
Any constituent Name in a constituent set will pass a value check
Entity: ''IFCWALL''
Requirements:
Material: ''Foo''
```

### Any layer Category in a layer set will pass a value check

``` ids material/pass-any_layer_category_in_a_layer_set_will_pass_a_value_check.ids
Any layer Category in a layer set will pass a value check
Entity: ''IFCWALL''
Requirements:
Material: ''Foo''
```

### Any layer Name in a layer set will pass a value check

``` ids material/pass-any_layer_name_in_a_layer_set_will_pass_a_value_check.ids
Any layer Name in a layer set will pass a value check
Entity: ''IFCWALL''
Requirements:
Material: ''Foo''
```

### Any material Category in a constituent set will pass a value check

``` ids material/pass-any_material_category_in_a_constituent_set_will_pass_a_value_check.ids
Any material Category in a constituent set will pass a value check
Entity: ''IFCWALL''
Requirements:
Material: ''Foo''
```

### Any material Category in a layer set will pass a value check

``` ids material/pass-any_material_category_in_a_layer_set_will_pass_a_value_check.ids
Any material Category in a layer set will pass a value check
Entity: ''IFCWALL''
Requirements:
Material: ''Foo''
```

### Any material Category in a list will pass a value check

``` ids material/pass-any_material_category_in_a_list_will_pass_a_value_check.ids
Any material Category in a list will pass a value check
Entity: ''IFCWALL''
Requirements:
Material: ''Foo''
```

### Any material category in a profile set will pass a value check

``` ids material/pass-any_material_category_in_a_profile_set_will_pass_a_value_check.ids
Any material category in a profile set will pass a value check
Entity: ''IFCWALL''
Requirements:
Material: ''Foo''
```

### Any material Name in a constituent set will pass a value check

``` ids material/pass-any_material_name_in_a_constituent_set_will_pass_a_value_check.ids
Any material Name in a constituent set will pass a value check
Entity: ''IFCWALL''
Requirements:
Material: ''Foo''
```

### Any material Name in a layer set will pass a value check

``` ids material/pass-any_material_name_in_a_layer_set_will_pass_a_value_check.ids
Any material Name in a layer set will pass a value check
Entity: ''IFCWALL''
Requirements:
Material: ''Foo''
```

### Any material Name in a list will pass a value check

``` ids material/pass-any_material_name_in_a_list_will_pass_a_value_check.ids
Any material Name in a list will pass a value check
Entity: ''IFCWALL''
Requirements:
Material: ''Foo''
```

### Any material Name in a profile set will pass a value check

``` ids material/pass-any_material_name_in_a_profile_set_will_pass_a_value_check.ids
Any material Name in a profile set will pass a value check
Entity: ''IFCWALL''
Requirements:
Material: ''Foo''
```

### Any profile Category in a profile set will pass a value check

``` ids material/pass-any_profile_category_in_a_profile_set_will_pass_a_value_check.ids
Any profile Category in a profile set will pass a value check
Entity: ''IFCWALL''
Requirements:
Material: ''Foo''
```

### Any profile Name in a profile set will pass a value check

``` ids material/pass-any_profile_name_in_a_profile_set_will_pass_a_value_check.ids
Any profile Name in a profile set will pass a value check
Entity: ''IFCWALL''
Requirements:
Material: ''Foo''
```

### Elements with any material will pass an empty material facet

``` ids material/pass-elements_with_any_material_will_pass_an_empty_material_facet.ids
Elements with any material will pass an empty material facet
Entity: ''IFCWALL''
Requirements:
Material: 
```

### Elements without a material always fail

``` ids material/fail-elements_without_a_material_always_fail.ids
Elements without a material always fail
Entity: ''IFCWALL''
Requirements:
Material: 
```

### Material with no data will fail a value check

``` ids material/fail-material_with_no_data_will_fail_a_value_check.ids
Material with no data will fail a value check
Entity: ''IfcWall''
Requirements:
Material: ''Foo''
```

### Occurrences can inherit materials from their types

``` ids material/pass-occurrences_can_inherit_materials_from_their_types.ids
Occurrences can inherit materials from their types
Entity: ''IFCWALL''
Requirements:
Material: ''Foo''
```

### Occurrences can override materials from their types

``` ids material/pass-occurrences_can_override_materials_from_their_types.ids
Occurrences can override materials from their types
Entity: ''IFCWALL''
Requirements:
Material: ''Foo''
```

## partof

### A group entity must match exactly 1/2

``` ids partof/fail-a_group_entity_must_match_exactly_1_2.ids
A group entity must match exactly 1/2
Entity: ''IFCELEMENTASSEMBLY''
Requirements:
PartOf: ''IFCGROUP'',IFCRELASSIGNSTOGROUP
```

### A group entity must match exactly 2/2

``` ids partof/pass-a_group_entity_must_match_exactly_2_2.ids
A group entity must match exactly 2/2
Entity: ''IFCELEMENTASSEMBLY''
Requirements:
PartOf: ''IFCINVENTORY'',IFCRELASSIGNSTOGROUP
```

### A group predefined type must match exactly 2/2

``` ids partof/fail-a_group_predefined_type_must_match_exactly_2_2.ids
A group predefined type must match exactly 2/2
Entity: ''IFCELEMENTASSEMBLY''
Requirements:
PartOf: ''IFCINVENTORY'',''BUNNARY'',IFCRELASSIGNSTOGROUP
```

### A group predefined type must match exactly 2/2

``` ids partof/pass-a_group_predefined_type_must_match_exactly_2_2.ids
A group predefined type must match exactly 2/2
Entity: ''IFCELEMENTASSEMBLY''
Requirements:
PartOf: ''IFCINVENTORY'',''BUNNY'',IFCRELASSIGNSTOGROUP
```

### A grouped element passes a group relationship

``` ids partof/pass-a_grouped_element_passes_a_group_relationship.ids
A grouped element passes a group relationship
Entity: ''IFCELEMENTASSEMBLY''
Requirements:
PartOf: Pattern(''.*''),IFCRELASSIGNSTOGROUP
```

### A non aggregated element fails an aggregate relationship

``` ids partof/fail-a_non_aggregated_element_fails_an_aggregate_relationship.ids
A non aggregated element fails an aggregate relationship
Entity: ''IFCWALL''
Requirements:
PartOf: Pattern(''.*''),IFCRELAGGREGATES
```

### A non grouped element fails a group relationship

``` ids partof/fail-a_non_grouped_element_fails_a_group_relationship.ids
A non grouped element fails a group relationship
Entity: ''IFCELEMENTASSEMBLY''
Requirements:
PartOf: Pattern(''.*''),IFCRELASSIGNSTOGROUP
```

### A prohibited facet returns the opposite of a required facet

``` ids partof/fail-a_prohibited_facet_returns_the_opposite_of_a_required_facet.ids
A prohibited facet returns the opposite of a required facet
Entity: ''IFCWALL''
Requirements:
PartOf: Prohibited,Pattern(''.*''),IFCRELAGGREGATES
```

### A required facet checks all parameters as normal

``` ids partof/pass-a_required_facet_checks_all_parameters_as_normal.ids
A required facet checks all parameters as normal
Entity: ''IFCWALL''
Requirements:
PartOf: Pattern(''.*''),IFCRELAGGREGATES
```

### An aggregate entity may pass any ancestral whole passes

``` ids partof/pass-an_aggregate_entity_may_pass_any_ancestral_whole_passes.ids
An aggregate entity may pass any ancestral whole passes
Entity: ''IFCBEAM''
Requirements:
PartOf: ''IFCELEMENTASSEMBLY'',IFCRELAGGREGATES
```

### An aggregate may specify the entity of the whole 1/2

``` ids partof/pass-an_aggregate_may_specify_the_entity_of_the_whole_1_2.ids
An aggregate may specify the entity of the whole 1/2
Entity: ''IFCBEAM''
Requirements:
PartOf: ''IFCSLAB'',IFCRELAGGREGATES
```

### An aggregate may specify the entity of the whole 2/2

``` ids partof/fail-an_aggregate_may_specify_the_entity_of_the_whole_2_2.ids
An aggregate may specify the entity of the whole 2/2
Entity: ''IFCBEAM''
Requirements:
PartOf: ''IFCWALL'',IFCRELAGGREGATES
```

### An aggregate may specify the predefined type of the whole 1/2

``` ids partof/pass-an_aggregate_may_specify_the_predefined_type_of_the_whole_1_2.ids
An aggregate may specify the predefined type of the whole 1/2
Entity: ''IFCBEAM''
Requirements:
PartOf: ''IFCSLAB'',''BASESLAB'',IFCRELAGGREGATES
```

### An aggregate may specify the predefined type of the whole 2/2

``` ids partof/fail-an_aggregate_may_specify_the_predefined_type_of_the_whole_2_2.ids
An aggregate may specify the predefined type of the whole 2/2
Entity: ''IFCBEAM''
Requirements:
PartOf: ''IFCSLAB'',''SLABRADOR'',IFCRELAGGREGATES
```

### An optional facet always passes regardless of outcome 1/2

``` ids partof/pass-an_optional_facet_always_passes_regardless_of_outcome_1_2.ids
An optional facet always passes regardless of outcome 1/2
Entity: ''IFCELEMENTASSEMBLY''
Requirements:
PartOf: Pattern(''.*''),IFCRELAGGREGATES
```

### An optional facet always passes regardless of outcome 2/2

``` ids partof/pass-an_optional_facet_always_passes_regardless_of_outcome_2_2.ids
An optional facet always passes regardless of outcome 2/2
Entity: ''IFCWALL''
Requirements:
PartOf: Pattern(''.*''),IFCRELAGGREGATES
```

### Any contained element passes a containment relationship 1/2

``` ids partof/fail-any_contained_element_passes_a_containment_relationship_1_2.ids
Any contained element passes a containment relationship 1/2
Entity: ''IFCELEMENTASSEMBLY''
Requirements:
PartOf: Pattern(''.*''),IFCRELCONTAINEDINSPATIALSTRUCTURE
```

### Any contained element passes a containment relationship 2/2

``` ids partof/pass-any_contained_element_passes_a_containment_relationship_2_2.ids
Any contained element passes a containment relationship 2/2
Entity: ''IFCELEMENTASSEMBLY''
Requirements:
PartOf: Pattern(''.*''),IFCRELCONTAINEDINSPATIALSTRUCTURE
```

### Any nested part passes a nest relationship

``` ids partof/pass-any_nested_part_passes_a_nest_relationship.ids
Any nested part passes a nest relationship
Entity: ''IFCDISCRETEACCESSORY''
Requirements:
PartOf: Pattern(''.*''),IFCRELNESTS
```

### Any nested whole fails a nest relationship

``` ids partof/fail-any_nested_whole_fails_a_nest_relationship.ids
Any nested whole fails a nest relationship
Entity: ''IFCFURNITURE''
Requirements:
PartOf: Pattern(''.*''),IFCRELNESTS
```

### Nesting may be indirect

``` ids partof/pass-nesting_may_be_indirect.ids
Nesting may be indirect
Entity: ''IFCMECHANICALFASTENER''
Requirements:
PartOf: ''IFCFURNITURE'',IFCRELNESTS
```

### The aggregated part passes an aggregate relationship

``` ids partof/pass-the_aggregated_part_passes_an_aggregate_relationship.ids
The aggregated part passes an aggregate relationship
Entity: ''IFCWALL''
Requirements:
PartOf: Pattern(''.*''),IFCRELAGGREGATES
```

### The aggregated whole fails an aggregate relationship

``` ids partof/fail-the_aggregated_whole_fails_an_aggregate_relationship.ids
The aggregated whole fails an aggregate relationship
Entity: ''IFCELEMENTASSEMBLY''
Requirements:
PartOf: Pattern(''.*''),IFCRELAGGREGATES
```

### The container entity must match exactly 1/2

``` ids partof/fail-the_container_entity_must_match_exactly_1_2.ids
The container entity must match exactly 1/2
Entity: ''IFCELEMENTASSEMBLY''
Requirements:
PartOf: ''IFCSITE'',IFCRELCONTAINEDINSPATIALSTRUCTURE
```

### The container entity must match exactly 2/2

``` ids partof/pass-the_container_entity_must_match_exactly_2_2.ids
The container entity must match exactly 2/2
Entity: ''IFCELEMENTASSEMBLY''
Requirements:
PartOf: ''IFCSPACE'',IFCRELCONTAINEDINSPATIALSTRUCTURE
```

### The container itself always fails

``` ids partof/fail-the_container_itself_always_fails.ids
The container itself always fails
Entity: ''IFCSPACE''
Requirements:
PartOf: Pattern(''.*''),IFCRELCONTAINEDINSPATIALSTRUCTURE
```

### The container may be indirect

``` ids partof/pass-the_container_may_be_indirect.ids
The container may be indirect
Entity: ''IFCBEAM''
Requirements:
PartOf: ''IFCSPACE'',IFCRELCONTAINEDINSPATIALSTRUCTURE
```

### The container predefined type must match exactly 1/2

``` ids partof/fail-the_container_predefined_type_must_match_exactly_1_2.ids
The container predefined type must match exactly 1/2
Entity: ''IFCELEMENTASSEMBLY''
Requirements:
PartOf: ''IFCSPACE'',''WARREN'',IFCRELCONTAINEDINSPATIALSTRUCTURE
```

### The container predefined type must match exactly 2/2

``` ids partof/pass-the_container_predefined_type_must_match_exactly_2_2.ids
The container predefined type must match exactly 2/2
Entity: ''IFCELEMENTASSEMBLY''
Requirements:
PartOf: ''IFCSPACE'',''BURROW'',IFCRELCONTAINEDINSPATIALSTRUCTURE
```

### The nest entity must match exactly 1/2

``` ids partof/fail-the_nest_entity_must_match_exactly_1_2.ids
The nest entity must match exactly 1/2
Entity: ''IFCDISCRETEACCESSORY''
Requirements:
PartOf: ''IFCBEAM'',IFCRELNESTS
```

### The nest entity must match exactly 2/2

``` ids partof/pass-the_nest_entity_must_match_exactly_2_2.ids
The nest entity must match exactly 2/2
Entity: ''IFCDISCRETEACCESSORY''
Requirements:
PartOf: ''IFCFURNITURE'',IFCRELNESTS
```

### The nest predefined type must match exactly 1/2

``` ids partof/fail-the_nest_predefined_type_must_match_exactly_1_2.ids
The nest predefined type must match exactly 1/2
Entity: ''IFCDISCRETEACCESSORY''
Requirements:
PartOf: ''IFCFURNITURE'',''LITTERBOX'',IFCRELNESTS
```

### The nest predefined type must match exactly 2/2

``` ids partof/pass-the_nest_predefined_type_must_match_exactly_2_2.ids
The nest predefined type must match exactly 2/2
Entity: ''IFCDISCRETEACCESSORY''
Requirements:
PartOf: ''IFCFURNITURE'',''WATERBOTTLE'',IFCRELNESTS
```

## property

### A logical unknown is considered falsey and will not pass

``` ids property/fail-a_logical_unknown_is_considered_falsey_and_will_not_pass.ids
A logical unknown is considered falsey and will not pass
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCDURATION
```

### A name check will match any property with any string value

``` ids property/pass-a_name_check_will_match_any_property_with_any_string_value.ids
A name check will match any property with any string value
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL
```

### A name check will match any quantity with any value

``` ids property/pass-a_name_check_will_match_any_quantity_with_any_value.ids
A name check will match any quantity with any value
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLENGTHMEASURE
```

### A number specified as a string is treated as a string

``` ids property/pass-a_number_specified_as_a_string_is_treated_as_a_string.ids
A number specified as a string is treated as a string
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL,''1''
```

### A prohibited facet returns the opposite of a required facet

``` ids property/fail-a_prohibited_facet_returns_the_opposite_of_a_required_facet.ids
A prohibited facet returns the opposite of a required facet
Entity: ''IFCWALL''
Requirements:
Property: Prohibited,''Foo_Bar'',''Foo'',IFCLABEL
```

### A property set to false is still considered a value and will pass a name check

``` ids property/pass-a_property_set_to_false_is_still_considered_a_value_and_will_pass_a_name_check.ids
A property set to false is still considered a value and will pass a name check
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCBOOLEAN
```

### A property set to true will pass a name check

``` ids property/pass-a_property_set_to_true_will_pass_a_name_check.ids
A property set to true will pass a name check
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCBOOLEAN
```

### A required facet checks all parameters as normal

``` ids property/pass-a_required_facet_checks_all_parameters_as_normal.ids
A required facet checks all parameters as normal
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL
```

### A zero duration will pass

``` ids property/pass-a_zero_duration_will_pass.ids
A zero duration will pass
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCDURATION
```

### All matching properties must satisfy requirements 1/3

``` ids property/pass-all_matching_properties_must_satisfy_requirements_1_3.ids
All matching properties must satisfy requirements 1/3
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',Pattern(''Foo.*''),IFCLABEL,''x''
```

### All matching properties must satisfy requirements 2/3

``` ids property/pass-all_matching_properties_must_satisfy_requirements_2_3.ids
All matching properties must satisfy requirements 2/3
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',Pattern(''Foo.*''),IFCLABEL,''x''
```

### All matching properties must satisfy requirements 3/3

``` ids property/fail-all_matching_properties_must_satisfy_requirements_3_3.ids
All matching properties must satisfy requirements 3/3
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',Pattern(''Foo.*''),IFCLABEL,''x''
```

### All matching property sets must satisfy requirements 1/3

``` ids property/pass-all_matching_property_sets_must_satisfy_requirements_1_3.ids
All matching property sets must satisfy requirements 1/3
Entity: ''IFCWALL''
Requirements:
Property: Pattern(''Foo_.*''),''Foo'',IFCLABEL
```

### All matching property sets must satisfy requirements 2/3

``` ids property/fail-all_matching_property_sets_must_satisfy_requirements_2_3.ids
All matching property sets must satisfy requirements 2/3
Entity: ''IFCWALL''
Requirements:
Property: Pattern(''Foo_.*''),''Foo'',IFCLABEL
```

### All matching property sets must satisfy requirements 3/3

``` ids property/pass-all_matching_property_sets_must_satisfy_requirements_3_3.ids
All matching property sets must satisfy requirements 3/3
Entity: ''IFCWALL''
Requirements:
Property: Pattern(''Foo_.*''),''Foo'',IFCLABEL
```

### An empty string is considered falsey and will not pass

``` ids property/fail-an_empty_string_is_considered_falsey_and_will_not_pass.ids
An empty string is considered falsey and will not pass
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLOGICAL
```

### An optional facet always passes regardless of outcome 1/2

``` ids property/pass-an_optional_facet_always_passes_regardless_of_outcome_1_2.ids
An optional facet always passes regardless of outcome 1/2
Entity: ''IFCWALL''
Requirements:
Property: Optional,''Foo_Bar'',''Foo'',IFCLABEL
```

### An optional facet always passes regardless of outcome 2/2

``` ids property/pass-an_optional_facet_always_passes_regardless_of_outcome_2_2.ids
An optional facet always passes regardless of outcome 2/2
Entity: ''IFCWALL''
Requirements:
Property: Optional,''Foo_Bar'',''Bar'',IFCLABEL
```

### Any matching value in a bounded property will pass 1/4

``` ids property/pass-any_matching_value_in_a_bounded_property_will_pass_1_4.ids
Any matching value in a bounded property will pass 1/4
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLENGTHMEASURE,''1''
```

### Any matching value in a bounded property will pass 2/4

``` ids property/pass-any_matching_value_in_a_bounded_property_will_pass_2_4.ids
Any matching value in a bounded property will pass 2/4
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLENGTHMEASURE,''5''
```

### Any matching value in a bounded property will pass 3/4

``` ids property/pass-any_matching_value_in_a_bounded_property_will_pass_3_4.ids
Any matching value in a bounded property will pass 3/4
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLENGTHMEASURE,''3''
```

### Any matching value in a bounded property will pass 4/4

``` ids property/fail-any_matching_value_in_a_bounded_property_will_pass_4_4.ids
Any matching value in a bounded property will pass 4/4
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLENGTHMEASURE,''2''
```

### Any matching value in a list property will pass 1/3

``` ids property/pass-any_matching_value_in_a_list_property_will_pass_1_3.ids
Any matching value in a list property will pass 1/3
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL,''X''
```

### Any matching value in a list property will pass 2/3

``` ids property/pass-any_matching_value_in_a_list_property_will_pass_2_3.ids
Any matching value in a list property will pass 2/3
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL,''Y''
```

### Any matching value in a list property will pass 3/3

``` ids property/fail-any_matching_value_in_a_list_property_will_pass_3_3.ids
Any matching value in a list property will pass 3/3
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL,''Z''
```

### Any matching value in a table property will pass 1/3

``` ids property/pass-any_matching_value_in_a_table_property_will_pass_1_3.ids
Any matching value in a table property will pass 1/3
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL,''X''
```

### Any matching value in a table property will pass 2/3

``` ids property/pass-any_matching_value_in_a_table_property_will_pass_2_3.ids
Any matching value in a table property will pass 2/3
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLENGTHMEASURE,''1''
```

### Any matching value in a table property will pass 3/3

``` ids property/fail-any_matching_value_in_a_table_property_will_pass_3_3.ids
Any matching value in a table property will pass 3/3
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL,''Y''
```

### Any matching value in an enumerated property will pass 1/3

``` ids property/pass-any_matching_value_in_an_enumerated_property_will_pass_1_3.ids
Any matching value in an enumerated property will pass 1/3
Entity: ''IFCWALL''
Requirements:
Property: ''Pset_WallCommon'',''Status'',IFCLABEL,''EXISTING''
```

### Any matching value in an enumerated property will pass 2/3

``` ids property/pass-any_matching_value_in_an_enumerated_property_will_pass_2_3.ids
Any matching value in an enumerated property will pass 2/3
Entity: ''IFCWALL''
Requirements:
Property: ''Pset_WallCommon'',''Status'',IFCLABEL,''DEMOLISH''
```

### Any matching value in an enumerated property will pass 3/3

``` ids property/fail-any_matching_value_in_an_enumerated_property_will_pass_3_3.ids
Any matching value in an enumerated property will pass 3/3
Entity: ''IFCWALL''
Requirements:
Property: ''Pset_WallCommon'',''Status'',IFCLABEL,''NEW''
```

### Booleans must be specified as uppercase strings 1/3

``` ids property/fail-booleans_must_be_specified_as_uppercase_strings_1_3.ids
Booleans must be specified as uppercase strings 1/3
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCBOOLEAN,''TRUE''
```

### Booleans must be specified as uppercase strings 2/3

``` ids property/pass-booleans_must_be_specified_as_uppercase_strings_2_3.ids
Booleans must be specified as uppercase strings 2/3
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCBOOLEAN,''FALSE''
```

### Booleans must be specified as uppercase strings 3/3

``` ids property/fail-booleans_must_be_specified_as_uppercase_strings_3_3.ids
Booleans must be specified as uppercase strings 3/3
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCBOOLEAN,''False''
```

### Complex properties are not supported 1/2

``` ids property/fail-complex_properties_are_not_supported_1_2.ids
Complex properties are not supported 1/2
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLENGTHMEASURE
```

### Complex properties are not supported 2/2

``` ids property/fail-complex_properties_are_not_supported_2_2.ids
Complex properties are not supported 2/2
Entity: ''IFCWALL''
Requirements:
Property: ''Foo'',''MyLength'',IFCLENGTHMEASURE
```

### Dates are treated as strings 1/2

``` ids property/pass-dates_are_treated_as_strings_1_2.ids
Dates are treated as strings 1/2
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCDATE,''2022-01-01''
```

### Dates are treated as strings 2/2

``` ids property/fail-dates_are_treated_as_strings_2_2.ids
Dates are treated as strings 2/2
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCDATE,''2022-01-01''
```

### Durations are treated as strings 1/2

``` ids property/fail-durations_are_treated_as_strings_1_2.ids
Durations are treated as strings 1/2
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCDURATION,''PT16H''
```

### Durations are treated as strings 1/2

``` ids property/pass-durations_are_treated_as_strings_1_2.ids
Durations are treated as strings 1/2
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCDURATION,''PT16H''
```

### Elements with a matching pset but no property also fail

``` ids property/fail-elements_with_a_matching_pset_but_no_property_also_fail.ids
Elements with a matching pset but no property also fail
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL
```

### Elements with no properties always fail

``` ids property/fail-elements_with_no_properties_always_fail.ids
Elements with no properties always fail
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL
```

### Floating point numbers are compared with a 1e-6 tolerance 1/4

``` ids property/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_1_4.ids
Floating point numbers are compared with a 1e-6 tolerance 1/4
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCREAL,''42.''
```

### Floating point numbers are compared with a 1e-6 tolerance 2/4

``` ids property/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_2_4.ids
Floating point numbers are compared with a 1e-6 tolerance 2/4
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCREAL,''42.''
```

### Floating point numbers are compared with a 1e-6 tolerance 3/4

``` ids property/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_3_4.ids
Floating point numbers are compared with a 1e-6 tolerance 3/4
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCREAL,''42.''
```

### Floating point numbers are compared with a 1e-6 tolerance 4/4

``` ids property/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_4_4.ids
Floating point numbers are compared with a 1e-6 tolerance 4/4
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCREAL,''42.''
```

### IDS does not handle string truncation such as for identifiers

``` ids property/fail-ids_does_not_handle_string_truncation_such_as_for_identifiers.ids
IDS does not handle string truncation such as for identifiers
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCIDENTIFIER,''123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345_extra_characters''
```

### If multiple properties are matched, all values must satisfy requirements 1/2

``` ids property/pass-if_multiple_properties_are_matched__all_values_must_satisfy_requirements_1_2.ids
If multiple properties are matched, all values must satisfy requirements 1/2
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',Pattern(''Foo.*''),IFCLABEL,Enumeration(''x'',''y'')
```

### If multiple properties are matched, all values must satisfy requirements 2/2

``` ids property/fail-if_multiple_properties_are_matched__all_values_must_satisfy_requirements_2_2.ids
If multiple properties are matched, all values must satisfy requirements 2/2
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',Pattern(''Foo.*''),IFCLABEL,Enumeration(''x'',''y'')
```

### Integer values are checked using type casting 1/4

``` ids property/pass-integer_values_are_checked_using_type_casting_1_4.ids
Integer values are checked using type casting 1/4
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCINTEGER,''42''
```

### Integer values are checked using type casting 2/4

``` ids property/pass-integer_values_are_checked_using_type_casting_2_4.ids
Integer values are checked using type casting 2/4
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCINTEGER,''42.''
```

### Integer values are checked using type casting 3/4

``` ids property/pass-integer_values_are_checked_using_type_casting_3_4.ids
Integer values are checked using type casting 3/4
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCINTEGER,''42.0''
```

### Integer values are checked using type casting 4/4

``` ids property/fail-integer_values_are_checked_using_type_casting_4_4.ids
Integer values are checked using type casting 4/4
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCINTEGER,''42.3''
```

### Measures are used to specify an IFC data type 1/2

``` ids property/fail-measures_are_used_to_specify_an_ifc_data_type_1_2.ids
Measures are used to specify an IFC data type 1/2
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCTIMEMEASURE,''2''
```

### Measures are used to specify an IFC data type 2/2

``` ids property/pass-measures_are_used_to_specify_an_ifc_data_type_2_2.ids
Measures are used to specify an IFC data type 2/2
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCTIMEMEASURE,''2''
```

### Non-ascii characters are treated without encoding

``` ids property/pass-non_ascii_characters_are_treated_without_encoding.ids
Non-ascii characters are treated without encoding
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL,''♫Don'tÄrgerhôtelЊет''
```

### Only specifically formatted numbers are allowed 1/4

``` ids property/fail-only_specifically_formatted_numbers_are_allowed_1_4.ids
Only specifically formatted numbers are allowed 1/4
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCREAL,''42,3''
```

### Only specifically formatted numbers are allowed 2/4

``` ids property/fail-only_specifically_formatted_numbers_are_allowed_2_4.ids
Only specifically formatted numbers are allowed 2/4
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCREAL,''123,4.5''
```

### Only specifically formatted numbers are allowed 3/4

``` ids property/pass-only_specifically_formatted_numbers_are_allowed_3_4.ids
Only specifically formatted numbers are allowed 3/4
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCREAL,''1.2345e3''
```

### Only specifically formatted numbers are allowed 4/4

``` ids property/pass-only_specifically_formatted_numbers_are_allowed_4_4.ids
Only specifically formatted numbers are allowed 4/4
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCREAL,''1.2345E3''
```

### Predefined properties are supported but discouraged 1/2

``` ids property/pass-predefined_properties_are_supported_but_discouraged_1_2.ids
Predefined properties are supported but discouraged 1/2
Entity: ''IFCDOOR''
Requirements:
Property: ''Foo_Bar'',''PanelOperation'',IFCDOORPANELOPERATIONENUM,''SWINGING''
```

### Predefined properties are supported but discouraged 2/2

``` ids property/fail-predefined_properties_are_supported_but_discouraged_2_2.ids
Predefined properties are supported but discouraged 2/2
Entity: ''IFCDOOR''
Requirements:
Property: ''Foo_Bar'',''PanelOperation'',IFCDOORPANELOPERATIONENUM,''SWONGING''
```

### Properties can be inherited from the type 1/2

``` ids property/pass-properties_can_be_inherited_from_the_type_1_2.ids
Properties can be inherited from the type 1/2
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL
```

### Properties can be inherited from the type 2/2

``` ids property/pass-properties_can_be_inherited_from_the_type_2_2.ids
Properties can be inherited from the type 2/2
Entity: ''IFCWALLTYPE''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL
```

### Properties can be overriden by an occurrence 1/2

``` ids property/pass-properties_can_be_overriden_by_an_occurrence_1_2.ids
Properties can be overriden by an occurrence 1/2
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL,''Bar''
```

### Properties can be overriden by an occurrence 2/2

``` ids property/fail-properties_can_be_overriden_by_an_occurrence_2_2.ids
Properties can be overriden by an occurrence 2/2
Entity: ''IFCWALLTYPE''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL,''Bar''
```

### Properties with a null value fail

``` ids property/fail-properties_with_a_null_value_fail.ids
Properties with a null value fail
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL
```

### Quantities must also match the appropriate measure

``` ids property/fail-quantities_must_also_match_the_appropriate_measure.ids
Quantities must also match the appropriate measure
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCAREAMEASURE
```

### Real values are checked using type casting 1/3

``` ids property/pass-real_values_are_checked_using_type_casting_1_3.ids
Real values are checked using type casting 1/3
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCREAL,''42''
```

### Real values are checked using type casting 2/3

``` ids property/pass-real_values_are_checked_using_type_casting_2_3.ids
Real values are checked using type casting 2/3
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCREAL,''42.0''
```

### Real values are checked using type casting 3/3

``` ids property/pass-real_values_are_checked_using_type_casting_3_3.ids
Real values are checked using type casting 3/3
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCREAL,''42.3''
```

### Reference properties are treated as objects and not supported

``` ids property/fail-reference_properties_are_treated_as_objects_and_not_supported.ids
Reference properties are treated as objects and not supported
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL
```

### Specifying a value fails against different values

``` ids property/fail-specifying_a_value_fails_against_different_values.ids
Specifying a value fails against different values
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL,''Bar''
```

### Specifying a value performs a case-sensitive match 1/2

``` ids property/pass-specifying_a_value_performs_a_case_sensitive_match_1_2.ids
Specifying a value performs a case-sensitive match 1/2
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL,''Bar''
```

### Specifying a value performs a case-sensitive match 2/2

``` ids property/fail-specifying_a_value_performs_a_case_sensitive_match_2_2.ids
Specifying a value performs a case-sensitive match 2/2
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLABEL,''Bar''
```

### Unit conversions shall take place to IDS-nominated standard units 1/2

``` ids property/fail-unit_conversions_shall_take_place_to_ids_nominated_standard_units_1_2.ids
Unit conversions shall take place to IDS-nominated standard units 1/2
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLENGTHMEASURE,''2''
```

### Unit conversions shall take place to IDS-nominated standard units 2/2

``` ids property/pass-unit_conversions_shall_take_place_to_ids_nominated_standard_units_2_2.ids
Unit conversions shall take place to IDS-nominated standard units 2/2
Entity: ''IFCWALL''
Requirements:
Property: ''Foo_Bar'',''Foo'',IFCLENGTHMEASURE,''2''
```

## restriction

### A bound can be inclusive 1/3

``` ids restriction/fail-a_bound_can_be_inclusive_1_3.ids
A bound can be inclusive 1/3
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',xs:integer MinExclusive(''0'') MaxExclusive(''10'')
```

### A bound can be inclusive 1/4

``` ids restriction/pass-a_bound_can_be_inclusive_1_4.ids
A bound can be inclusive 1/4
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',xs:integer MinInclusive(''0'') MaxInclusive(''10'')
```

### A bound can be inclusive 2/3

``` ids restriction/pass-a_bound_can_be_inclusive_2_3.ids
A bound can be inclusive 2/3
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',xs:integer MinExclusive(''0'') MaxExclusive(''10'')
```

### A bound can be inclusive 2/4

``` ids restriction/pass-a_bound_can_be_inclusive_2_4.ids
A bound can be inclusive 2/4
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',xs:integer MinInclusive(''0'') MaxInclusive(''10'')
```

### A bound can be inclusive 3/3

``` ids restriction/fail-a_bound_can_be_inclusive_3_3.ids
A bound can be inclusive 3/3
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',xs:integer MinExclusive(''0'') MaxExclusive(''10'')
```

### A bound can be inclusive 3/4

``` ids restriction/pass-a_bound_can_be_inclusive_3_4.ids
A bound can be inclusive 3/4
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',xs:integer MinInclusive(''0'') MaxInclusive(''10'')
```

### A bound can be inclusive 4/4

``` ids restriction/fail-a_bound_can_be_inclusive_4_4.ids
A bound can be inclusive 4/4
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',xs:integer MinInclusive(''0'') MaxInclusive(''10'')
```

### An enumeration matches case sensitively 1/3

``` ids restriction/fail-an_enumeration_matches_case_sensitively_1_3.ids
An enumeration matches case sensitively 1/3
Optional
Entity: ''IfcWall''
Requirements:
Attribute: ''Name'',Enumeration(''Foo'',''Bar'')
```

### An enumeration matches case sensitively 1/3

``` ids restriction/pass-an_enumeration_matches_case_sensitively_1_3.ids
An enumeration matches case sensitively 1/3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',Enumeration(''Foo'',''Bar'')
```

### An enumeration matches case sensitively 2/3

``` ids restriction/pass-an_enumeration_matches_case_sensitively_2_3.ids
An enumeration matches case sensitively 2/3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',Enumeration(''Foo'',''Bar'')
```

### An enumeration matches case sensitively 3/3

``` ids restriction/fail-an_enumeration_matches_case_sensitively_3_3.ids
An enumeration matches case sensitively 3/3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',Enumeration(''Foo'',''Bar'')
```

### Length checks can be used 1/2

``` ids restriction/fail-length_checks_can_be_used_1_2.ids
Length checks can be used 1/2
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',Length(''2'')
```

### Length checks can be used 1/2

``` ids restriction/pass-length_checks_can_be_used_1_2.ids
Length checks can be used 1/2
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',Length(''2'')
```

### Max and min length checks can be used 1/3

``` ids restriction/fail-max_and_min_length_checks_can_be_used_1_3.ids
Max and min length checks can be used 1/3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',MinLength(''2'') MaxLength(''3'')
```

### Max and min length checks can be used 2/3

``` ids restriction/pass-max_and_min_length_checks_can_be_used_2_3.ids
Max and min length checks can be used 2/3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',MinLength(''2'') MaxLength(''3'')
```

### Max and min length checks can be used 3/3

``` ids restriction/pass-max_and_min_length_checks_can_be_used_3_3.ids
Max and min length checks can be used 3/3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',MinLength(''2'') MaxLength(''3'')
```

### Max and min length checks can be used 4/3

``` ids restriction/fail-max_and_min_length_checks_can_be_used_4_3.ids
Max and min length checks can be used 4/3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',MinLength(''2'') MaxLength(''3'')
```

### Patterns always fail on any number

``` ids restriction/fail-patterns_always_fail_on_any_number.ids
Patterns always fail on any number
Optional
Entity: ''IfcSurfaceStyleRefraction''
Requirements:
Attribute: ''RefractionIndex'',Pattern(''.*'')
```

### Patterns only work on strings and nothing else

``` ids restriction/fail-patterns_only_work_on_strings_and_nothing_else.ids
Patterns only work on strings and nothing else
Entity: ''IFCSURFACESTYLEREFRACTION''
Requirements:
Attribute: ''RefractionIndex'',Pattern(''.*'')
```

### Regex patterns can be used 1/3

``` ids restriction/pass-regex_patterns_can_be_used_1_3.ids
Regex patterns can be used 1/3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',Pattern(''[A-Z]{2}[0-9]{2}'')
```

### Regex patterns can be used 2/3

``` ids restriction/pass-regex_patterns_can_be_used_2_3.ids
Regex patterns can be used 2/3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',Pattern(''[A-Z]{2}[0-9]{2}'')
```

### Regex patterns can be used 3/3

``` ids restriction/fail-regex_patterns_can_be_used_3_3.ids
Regex patterns can be used 3/3
Entity: ''IFCWALL''
Requirements:
Attribute: ''Name'',Pattern(''[A-Z]{2}[0-9]{2}'')
```

