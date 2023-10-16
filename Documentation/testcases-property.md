# Property testcases

These testcases are designed to help describe behaviour in edge cases and ambiguities. All valid IDS implementations must demonstrate identical behaviour to these test cases.

## [FAIL] Elements with no properties always fail

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#4,#2,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/property/fail-elements_with_no_properties_always_fail.ids) - [Sample IFC: 7](testcases/property/fail-elements_with_no_properties_always_fail.ifc)

## [FAIL] Elements with a matching pset but no property also fail

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#4,#2,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
~~~

[Sample IDS](testcases/property/fail-elements_with_a_matching_pset_but_no_property_also_fail.ids) - [Sample IFC: 7](testcases/property/fail-elements_with_a_matching_pset_but_no_property_also_fail.ifc)

## [FAIL] Properties with a null value fail

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#4,#2,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,$,$);
~~~

[Sample IDS](testcases/property/fail-properties_with_a_null_value_fail.ids) - [Sample IFC: 7](testcases/property/fail-properties_with_a_null_value_fail.ifc)

## [PASS] A name check will match any property with any string value

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#4,#2,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,$,$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-a_name_check_will_match_any_property_with_any_string_value.ids) - [Sample IFC: 7](testcases/property/pass-a_name_check_will_match_any_property_with_any_string_value.ifc)

## [PASS] A required facet checks all parameters as normal

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-a_required_facet_checks_all_parameters_as_normal.ids) - [Sample IFC: 7](testcases/property/pass-a_required_facet_checks_all_parameters_as_normal.ifc)

## [FAIL] A prohibited facet returns the opposite of a required facet

~~~xml
<property datatype="IFCLABEL" minOccurs="0" maxOccurs="0">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/fail-a_prohibited_facet_returns_the_opposite_of_a_required_facet.ids) - [Sample IFC: 7](testcases/property/fail-a_prohibited_facet_returns_the_opposite_of_a_required_facet.ifc)

## [PASS] An optional facet always passes regardless of outcome 1/2

~~~xml
<property datatype="IFCLABEL" minOccurs="0" maxOccurs="unbounded">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-an_optional_facet_always_passes_regardless_of_outcome_1_2.ids) - [Sample IFC: 7](testcases/property/pass-an_optional_facet_always_passes_regardless_of_outcome_1_2.ifc)

## [PASS] An optional facet always passes regardless of outcome 2/2

~~~xml
<property datatype="IFCLABEL" minOccurs="0" maxOccurs="unbounded">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Bar</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-an_optional_facet_always_passes_regardless_of_outcome_2_2.ids) - [Sample IFC: 7](testcases/property/pass-an_optional_facet_always_passes_regardless_of_outcome_2_2.ifc)

## [FAIL] An empty string is considered falsey and will not pass

~~~xml
<property datatype="IFCLOGICAL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL(''),$);
~~~

[Sample IDS](testcases/property/fail-an_empty_string_is_considered_falsey_and_will_not_pass.ids) - [Sample IFC: 7](testcases/property/fail-an_empty_string_is_considered_falsey_and_will_not_pass.ifc)

## [FAIL] A logical unknown is considered falsey and will not pass

~~~xml
<property datatype="IFCDURATION" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLOGICAL(.U.),$);
~~~

[Sample IDS](testcases/property/fail-a_logical_unknown_is_considered_falsey_and_will_not_pass.ids) - [Sample IFC: 7](testcases/property/fail-a_logical_unknown_is_considered_falsey_and_will_not_pass.ifc)

## [PASS] A zero duration will pass

~~~xml
<property datatype="IFCDURATION" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P0D'),$);
~~~

[Sample IDS](testcases/property/pass-a_zero_duration_will_pass.ids) - [Sample IFC: 7](testcases/property/pass-a_zero_duration_will_pass.ifc)

## [PASS] A property set to true will pass a name check

~~~xml
<property datatype="IFCBOOLEAN" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.T.),$);
~~~

[Sample IDS](testcases/property/pass-a_property_set_to_true_will_pass_a_name_check.ids) - [Sample IFC: 7](testcases/property/pass-a_property_set_to_true_will_pass_a_name_check.ifc)

## [PASS] A property set to false is still considered a value and will pass a name check

~~~xml
<property datatype="IFCBOOLEAN" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
~~~

[Sample IDS](testcases/property/pass-a_property_set_to_false_is_still_considered_a_value_and_will_pass_a_name_check.ids) - [Sample IFC: 7](testcases/property/pass-a_property_set_to_false_is_still_considered_a_value_and_will_pass_a_name_check.ifc)

## [PASS] Specifying a value performs a case-sensitive match 1/2

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>Bar</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#5,#4,#2));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-specifying_a_value_performs_a_case_sensitive_match_1_2.ids) - [Sample IFC: 7](testcases/property/pass-specifying_a_value_performs_a_case_sensitive_match_1_2.ifc)

## [FAIL] Specifying a value performs a case-sensitive match 2/2

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>Bar</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#5,#4,#2));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('bar'),$);
~~~

[Sample IDS](testcases/property/fail-specifying_a_value_performs_a_case_sensitive_match_2_2.ids) - [Sample IFC: 7](testcases/property/fail-specifying_a_value_performs_a_case_sensitive_match_2_2.ifc)

## [FAIL] Specifying a value fails against different values

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>Bar</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#5,#4,#2));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Baz'),$);
~~~

[Sample IDS](testcases/property/fail-specifying_a_value_fails_against_different_values.ids) - [Sample IFC: 7](testcases/property/fail-specifying_a_value_fails_against_different_values.ifc)

## [PASS] Non-ascii characters are treated without encoding

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>♫Don'tÄrgerhôtelЊет</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#5,#4,#2));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('\X2\266B\X0\Don''t\X2\00C4\X0\rgerh\X2\00F4\X0\tel\X2\040A04350442\X0\'),$);
~~~

[Sample IDS](testcases/property/pass-non_ascii_characters_are_treated_without_encoding.ids) - [Sample IFC: 7](testcases/property/pass-non_ascii_characters_are_treated_without_encoding.ifc)

## [FAIL] IDS does not handle string truncation such as for identifiers

~~~xml
<property datatype="IFCIDENTIFIER" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345_extra_characters</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#5,#4,#2));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
~~~

[Sample IDS](testcases/property/fail-ids_does_not_handle_string_truncation_such_as_for_identifiers.ids) - [Sample IFC: 7](testcases/property/fail-ids_does_not_handle_string_truncation_such_as_for_identifiers.ifc)

## [PASS] A number specified as a string is treated as a string

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>1</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('1'),$);
~~~

[Sample IDS](testcases/property/pass-a_number_specified_as_a_string_is_treated_as_a_string.ids) - [Sample IFC: 7](testcases/property/pass-a_number_specified_as_a_string_is_treated_as_a_string.ifc)

## [PASS] Integer values are checked using type casting 1/4

~~~xml
<property datatype="IFCINTEGER" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>42</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCINTEGER(42),$);
~~~

[Sample IDS](testcases/property/pass-integer_values_are_checked_using_type_casting_1_4.ids) - [Sample IFC: 7](testcases/property/pass-integer_values_are_checked_using_type_casting_1_4.ifc)

## [PASS] Integer values are checked using type casting 2/4

~~~xml
<property datatype="IFCINTEGER" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>42.</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCINTEGER(42),$);
~~~

[Sample IDS](testcases/property/pass-integer_values_are_checked_using_type_casting_2_4.ids) - [Sample IFC: 7](testcases/property/pass-integer_values_are_checked_using_type_casting_2_4.ifc)

## [PASS] Integer values are checked using type casting 3/4

~~~xml
<property datatype="IFCINTEGER" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>42.0</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCINTEGER(42),$);
~~~

[Sample IDS](testcases/property/pass-integer_values_are_checked_using_type_casting_3_4.ids) - [Sample IFC: 7](testcases/property/pass-integer_values_are_checked_using_type_casting_3_4.ifc)

## [FAIL] Integer values are checked using type casting 4/4

~~~xml
<property datatype="IFCINTEGER" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>42.3</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCINTEGER(42),$);
~~~

[Sample IDS](testcases/property/fail-integer_values_are_checked_using_type_casting_4_4.ids) - [Sample IFC: 7](testcases/property/fail-integer_values_are_checked_using_type_casting_4_4.ifc)

## [PASS] Real values are checked using type casting 1/3

~~~xml
<property datatype="IFCREAL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>42</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(42.),$);
~~~

[Sample IDS](testcases/property/pass-real_values_are_checked_using_type_casting_1_3.ids) - [Sample IFC: 7](testcases/property/pass-real_values_are_checked_using_type_casting_1_3.ifc)

## [PASS] Real values are checked using type casting 2/3

~~~xml
<property datatype="IFCREAL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>42.0</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(42.),$);
~~~

[Sample IDS](testcases/property/pass-real_values_are_checked_using_type_casting_2_3.ids) - [Sample IFC: 7](testcases/property/pass-real_values_are_checked_using_type_casting_2_3.ifc)

## [PASS] Real values are checked using type casting 3/3

~~~xml
<property datatype="IFCREAL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>42.3</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(42.3),$);
~~~

[Sample IDS](testcases/property/pass-real_values_are_checked_using_type_casting_3_3.ids) - [Sample IFC: 7](testcases/property/pass-real_values_are_checked_using_type_casting_3_3.ifc)

## [FAIL] Only specifically formatted numbers are allowed 1/4

~~~xml
<property datatype="IFCREAL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>42,3</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(42.3),$);
~~~

[Sample IDS](testcases/property/fail-only_specifically_formatted_numbers_are_allowed_1_4.ids) - [Sample IFC: 7](testcases/property/fail-only_specifically_formatted_numbers_are_allowed_1_4.ifc)

## [FAIL] Only specifically formatted numbers are allowed 2/4

~~~xml
<property datatype="IFCREAL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>123,4.5</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(1234.5),$);
~~~

[Sample IDS](testcases/property/fail-only_specifically_formatted_numbers_are_allowed_2_4.ids) - [Sample IFC: 7](testcases/property/fail-only_specifically_formatted_numbers_are_allowed_2_4.ifc)

## [PASS] Only specifically formatted numbers are allowed 3/4

~~~xml
<property datatype="IFCREAL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>1.2345e3</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(1234.5),$);
~~~

[Sample IDS](testcases/property/pass-only_specifically_formatted_numbers_are_allowed_3_4.ids) - [Sample IFC: 7](testcases/property/pass-only_specifically_formatted_numbers_are_allowed_3_4.ifc)

## [PASS] Only specifically formatted numbers are allowed 4/4

~~~xml
<property datatype="IFCREAL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>1.2345E3</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(1234.5),$);
~~~

[Sample IDS](testcases/property/pass-only_specifically_formatted_numbers_are_allowed_4_4.ids) - [Sample IFC: 7](testcases/property/pass-only_specifically_formatted_numbers_are_allowed_4_4.ifc)

## [PASS] Floating point numbers are compared with a 1e-6 tolerance 1/4

~~~xml
<property datatype="IFCREAL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>42.</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(42.000042),$);
~~~

[Sample IDS](testcases/property/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_1_4.ids) - [Sample IFC: 7](testcases/property/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_1_4.ifc)

## [PASS] Floating point numbers are compared with a 1e-6 tolerance 2/4

~~~xml
<property datatype="IFCREAL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>42.</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(41.999958),$);
~~~

[Sample IDS](testcases/property/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_2_4.ids) - [Sample IFC: 7](testcases/property/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_2_4.ifc)

## [FAIL] Floating point numbers are compared with a 1e-6 tolerance 3/4

~~~xml
<property datatype="IFCREAL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>42.</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(42.000084),$);
~~~

[Sample IDS](testcases/property/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_3_4.ids) - [Sample IFC: 7](testcases/property/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_3_4.ifc)

## [FAIL] Floating point numbers are compared with a 1e-6 tolerance 4/4

~~~xml
<property datatype="IFCREAL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>42.</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(41.999916),$);
~~~

[Sample IDS](testcases/property/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_4_4.ids) - [Sample IFC: 7](testcases/property/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_4_4.ifc)

## [FAIL] Booleans must be specified as uppercase strings 1/3

~~~xml
<property datatype="IFCBOOLEAN" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>TRUE</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
~~~

[Sample IDS](testcases/property/fail-booleans_must_be_specified_as_uppercase_strings_1_3.ids) - [Sample IFC: 7](testcases/property/fail-booleans_must_be_specified_as_uppercase_strings_1_3.ifc)

## [PASS] Booleans must be specified as uppercase strings 2/3

~~~xml
<property datatype="IFCBOOLEAN" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>FALSE</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
~~~

[Sample IDS](testcases/property/pass-booleans_must_be_specified_as_uppercase_strings_2_3.ids) - [Sample IFC: 7](testcases/property/pass-booleans_must_be_specified_as_uppercase_strings_2_3.ifc)

## [FAIL] Booleans must be specified as uppercase strings 3/3

~~~xml
<property datatype="IFCBOOLEAN" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>False</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
~~~

[Sample IDS](testcases/property/fail-booleans_must_be_specified_as_uppercase_strings_3_3.ids) - [Sample IFC: 7](testcases/property/fail-booleans_must_be_specified_as_uppercase_strings_3_3.ifc)

## [PASS] Dates are treated as strings 1/2

~~~xml
<property datatype="IFCDATE" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>2022-01-01</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDATE('2022-01-01'),$);
~~~

[Sample IDS](testcases/property/pass-dates_are_treated_as_strings_1_2.ids) - [Sample IFC: 7](testcases/property/pass-dates_are_treated_as_strings_1_2.ifc)

## [FAIL] Dates are treated as strings 2/2

~~~xml
<property datatype="IFCDATE" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>2022-01-01</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDATE('2022-01-01+00:00'),$);
~~~

[Sample IDS](testcases/property/fail-dates_are_treated_as_strings_2_2.ids) - [Sample IFC: 7](testcases/property/fail-dates_are_treated_as_strings_2_2.ifc)

## [PASS] Durations are treated as strings 1/2

~~~xml
<property datatype="IFCDURATION" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>PT16H</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('PT16H'),$);
~~~

[Sample IDS](testcases/property/pass-durations_are_treated_as_strings_1_2.ids) - [Sample IFC: 7](testcases/property/pass-durations_are_treated_as_strings_1_2.ifc)

## [FAIL] Durations are treated as strings 1/2

~~~xml
<property datatype="IFCDURATION" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>PT16H</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
~~~

[Sample IDS](testcases/property/fail-durations_are_treated_as_strings_1_2.ids) - [Sample IFC: 7](testcases/property/fail-durations_are_treated_as_strings_1_2.ifc)

## [PASS] Any matching value in an enumerated property will pass 1/3

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Pset_WallCommon</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Status</simpleValue>
  </name>
  <value>
    <simpleValue>EXISTING</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#4,#2,#5));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Pset_WallCommon',$,(#11));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#11=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#10);
~~~

[Sample IDS](testcases/property/pass-any_matching_value_in_an_enumerated_property_will_pass_1_3.ids) - [Sample IFC: 7](testcases/property/pass-any_matching_value_in_an_enumerated_property_will_pass_1_3.ifc)

## [PASS] Any matching value in an enumerated property will pass 2/3

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Pset_WallCommon</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Status</simpleValue>
  </name>
  <value>
    <simpleValue>DEMOLISH</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#4,#2,#5));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Pset_WallCommon',$,(#11));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#11=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#10);
~~~

[Sample IDS](testcases/property/pass-any_matching_value_in_an_enumerated_property_will_pass_2_3.ids) - [Sample IFC: 7](testcases/property/pass-any_matching_value_in_an_enumerated_property_will_pass_2_3.ifc)

## [FAIL] Any matching value in an enumerated property will pass 3/3

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Pset_WallCommon</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Status</simpleValue>
  </name>
  <value>
    <simpleValue>NEW</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#4,#2,#5));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Pset_WallCommon',$,(#11));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#11=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#10);
~~~

[Sample IDS](testcases/property/fail-any_matching_value_in_an_enumerated_property_will_pass_3_3.ids) - [Sample IFC: 7](testcases/property/fail-any_matching_value_in_an_enumerated_property_will_pass_3_3.ifc)

## [PASS] Any matching value in a list property will pass 1/3

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>X</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#4,#5,#2));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
~~~

[Sample IDS](testcases/property/pass-any_matching_value_in_a_list_property_will_pass_1_3.ids) - [Sample IFC: 7](testcases/property/pass-any_matching_value_in_a_list_property_will_pass_1_3.ifc)

## [PASS] Any matching value in a list property will pass 2/3

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>Y</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#4,#5,#2));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
~~~

[Sample IDS](testcases/property/pass-any_matching_value_in_a_list_property_will_pass_2_3.ids) - [Sample IFC: 7](testcases/property/pass-any_matching_value_in_a_list_property_will_pass_2_3.ifc)

## [FAIL] Any matching value in a list property will pass 3/3

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>Z</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#4,#5,#2));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
~~~

[Sample IDS](testcases/property/fail-any_matching_value_in_a_list_property_will_pass_3_3.ids) - [Sample IFC: 7](testcases/property/fail-any_matching_value_in_a_list_property_will_pass_3_3.ifc)

## [PASS] Any matching value in a bounded property will pass 1/4

~~~xml
<property datatype="IFCLENGTHMEASURE" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>1</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#2,#3,#5,#4));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
~~~

[Sample IDS](testcases/property/pass-any_matching_value_in_a_bounded_property_will_pass_1_4.ids) - [Sample IFC: 7](testcases/property/pass-any_matching_value_in_a_bounded_property_will_pass_1_4.ifc)

## [PASS] Any matching value in a bounded property will pass 2/4

~~~xml
<property datatype="IFCLENGTHMEASURE" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>5</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#2,#3,#5,#4));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
~~~

[Sample IDS](testcases/property/pass-any_matching_value_in_a_bounded_property_will_pass_2_4.ids) - [Sample IFC: 7](testcases/property/pass-any_matching_value_in_a_bounded_property_will_pass_2_4.ifc)

## [PASS] Any matching value in a bounded property will pass 3/4

~~~xml
<property datatype="IFCLENGTHMEASURE" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>3</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#2,#3,#5,#4));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
~~~

[Sample IDS](testcases/property/pass-any_matching_value_in_a_bounded_property_will_pass_3_4.ids) - [Sample IFC: 7](testcases/property/pass-any_matching_value_in_a_bounded_property_will_pass_3_4.ifc)

## [FAIL] Any matching value in a bounded property will pass 4/4

~~~xml
<property datatype="IFCLENGTHMEASURE" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>2</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#2,#3,#5,#4));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
~~~

[Sample IDS](testcases/property/fail-any_matching_value_in_a_bounded_property_will_pass_4_4.ids) - [Sample IFC: 7](testcases/property/fail-any_matching_value_in_a_bounded_property_will_pass_4_4.ifc)

## [PASS] Any matching value in a table property will pass 1/3

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>X</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#4,#2,#5));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
~~~

[Sample IDS](testcases/property/pass-any_matching_value_in_a_table_property_will_pass_1_3.ids) - [Sample IFC: 7](testcases/property/pass-any_matching_value_in_a_table_property_will_pass_1_3.ifc)

## [PASS] Any matching value in a table property will pass 2/3

~~~xml
<property datatype="IFCLENGTHMEASURE" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>1</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#4,#2,#5));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
~~~

[Sample IDS](testcases/property/pass-any_matching_value_in_a_table_property_will_pass_2_3.ids) - [Sample IFC: 7](testcases/property/pass-any_matching_value_in_a_table_property_will_pass_2_3.ifc)

## [FAIL] Any matching value in a table property will pass 3/3

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>Y</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#4,#2,#5));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
~~~

[Sample IDS](testcases/property/fail-any_matching_value_in_a_table_property_will_pass_3_3.ids) - [Sample IFC: 7](testcases/property/fail-any_matching_value_in_a_table_property_will_pass_3_3.ifc)

## [FAIL] Reference properties are treated as objects and not supported

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
~~~

[Sample IDS](testcases/property/fail-reference_properties_are_treated_as_objects_and_not_supported.ids) - [Sample IFC: 7](testcases/property/fail-reference_properties_are_treated_as_objects_and_not_supported.ifc)

## [PASS] Predefined properties are supported but discouraged 1/2

~~~xml
<property datatype="IFCDOORPANELOPERATIONENUM" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>PanelOperation</simpleValue>
  </name>
  <value>
    <simpleValue>SWINGING</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCDOOR('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCDOORPANELPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
~~~

[Sample IDS](testcases/property/pass-predefined_properties_are_supported_but_discouraged_1_2.ids) - [Sample IFC: 7](testcases/property/pass-predefined_properties_are_supported_but_discouraged_1_2.ifc)

## [FAIL] Predefined properties are supported but discouraged 2/2

~~~xml
<property datatype="IFCDOORPANELOPERATIONENUM" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>PanelOperation</simpleValue>
  </name>
  <value>
    <simpleValue>SWONGING</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCDOOR('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCDOORPANELPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
~~~

[Sample IDS](testcases/property/fail-predefined_properties_are_supported_but_discouraged_2_2.ids) - [Sample IFC: 7](testcases/property/fail-predefined_properties_are_supported_but_discouraged_2_2.ifc)

## [PASS] A name check will match any quantity with any value

~~~xml
<property datatype="IFCLENGTHMEASURE" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCELEMENTQUANTITY('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
~~~

[Sample IDS](testcases/property/pass-a_name_check_will_match_any_quantity_with_any_value.ids) - [Sample IFC: 7](testcases/property/pass-a_name_check_will_match_any_quantity_with_any_value.ifc)

## [FAIL] Quantities must also match the appropriate measure

~~~xml
<property datatype="IFCAREAMEASURE" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCELEMENTQUANTITY('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
~~~

[Sample IDS](testcases/property/fail-quantities_must_also_match_the_appropriate_measure.ids) - [Sample IFC: 7](testcases/property/fail-quantities_must_also_match_the_appropriate_measure.ifc)

## [FAIL] Complex properties are not supported 1/2

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#11));
#11=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
~~~

[Sample IDS](testcases/property/fail-complex_properties_are_not_supported_1_2.ids) - [Sample IFC: 7](testcases/property/fail-complex_properties_are_not_supported_1_2.ifc)

## [FAIL] Complex properties are not supported 2/2

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Rabbits</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#11));
#11=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
~~~

[Sample IDS](testcases/property/fail-complex_properties_are_not_supported_2_2.ids) - [Sample IFC: 7](testcases/property/fail-complex_properties_are_not_supported_2_2.ifc)

## [FAIL] Complex properties are not supported 1/2

~~~xml
<property datatype="IFCLENGTHMEASURE" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCELEMENTQUANTITY('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#11),'FurThickness',$,$);
#11=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
~~~

[Sample IDS](testcases/property/fail-complex_properties_are_not_supported_1_2.ids) - [Sample IFC: 7](testcases/property/fail-complex_properties_are_not_supported_1_2.ifc)

## [FAIL] Complex properties are not supported 2/2

~~~xml
<property datatype="IFCLENGTHMEASURE" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo</simpleValue>
  </propertySet>
  <name>
    <simpleValue>MyLength</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCELEMENTQUANTITY('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#11),'FurThickness',$,$);
#11=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
~~~

[Sample IDS](testcases/property/fail-complex_properties_are_not_supported_2_2.ids) - [Sample IFC: 7](testcases/property/fail-complex_properties_are_not_supported_2_2.ifc)

## [PASS] All matching property sets must satisfy requirements 1/3

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <xs:restriction base="xs:string">
      <xs:pattern value="Foo_.*"/>
    </xs:restriction>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-all_matching_property_sets_must_satisfy_requirements_1_3.ids) - [Sample IFC: 7](testcases/property/pass-all_matching_property_sets_must_satisfy_requirements_1_3.ifc)

## [FAIL] All matching property sets must satisfy requirements 2/3

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <xs:restriction base="xs:string">
      <xs:pattern value="Foo_.*"/>
    </xs:restriction>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#11=IFCPROPERTYSET('1n81bO_6nGjgypJwWUVavJ',$,'Foo_Baz',$,(#13));
#12=IFCRELDEFINESBYPROPERTIES('3b0AoFivPN6RDJO6UL_GfZ',$,$,$,(#7),#11);
#13=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
~~~

[Sample IDS](testcases/property/fail-all_matching_property_sets_must_satisfy_requirements_2_3.ids) - [Sample IFC: 7](testcases/property/fail-all_matching_property_sets_must_satisfy_requirements_2_3.ifc)

## [PASS] All matching property sets must satisfy requirements 3/3

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <xs:restriction base="xs:string">
      <xs:pattern value="Foo_.*"/>
    </xs:restriction>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#11=IFCPROPERTYSET('1n81bO_6nGjgypJwWUVavJ',$,'Foo_Baz',$,(#13,#14));
#12=IFCRELDEFINESBYPROPERTIES('3b0AoFivPN6RDJO6UL_GfZ',$,$,$,(#7),#11);
#13=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#14=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-all_matching_property_sets_must_satisfy_requirements_3_3.ids) - [Sample IFC: 7](testcases/property/pass-all_matching_property_sets_must_satisfy_requirements_3_3.ifc)

## [PASS] All matching properties must satisfy requirements 1/3

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <xs:restriction base="xs:string">
      <xs:pattern value="Foo.*"/>
    </xs:restriction>
  </name>
  <value>
    <simpleValue>x</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#5,#4,#2));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
~~~

[Sample IDS](testcases/property/pass-all_matching_properties_must_satisfy_requirements_1_3.ids) - [Sample IFC: 7](testcases/property/pass-all_matching_properties_must_satisfy_requirements_1_3.ifc)

## [PASS] All matching properties must satisfy requirements 2/3

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <xs:restriction base="xs:string">
      <xs:pattern value="Foo.*"/>
    </xs:restriction>
  </name>
  <value>
    <simpleValue>x</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#5,#4,#2));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#11=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('x'),$);
~~~

[Sample IDS](testcases/property/pass-all_matching_properties_must_satisfy_requirements_2_3.ids) - [Sample IFC: 7](testcases/property/pass-all_matching_properties_must_satisfy_requirements_2_3.ifc)

## [FAIL] All matching properties must satisfy requirements 3/3

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <xs:restriction base="xs:string">
      <xs:pattern value="Foo.*"/>
    </xs:restriction>
  </name>
  <value>
    <simpleValue>x</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#5,#4,#2));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#11=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
~~~

[Sample IDS](testcases/property/fail-all_matching_properties_must_satisfy_requirements_3_3.ids) - [Sample IFC: 7](testcases/property/fail-all_matching_properties_must_satisfy_requirements_3_3.ifc)

## [PASS] If multiple properties are matched, all values must satisfy requirements 1/2

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <xs:restriction base="xs:string">
      <xs:pattern value="Foo.*"/>
    </xs:restriction>
  </name>
  <value>
    <xs:restriction base="xs:string">
      <xs:enumeration value="x"/>
      <xs:enumeration value="y"/>
    </xs:restriction>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#11=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
~~~

[Sample IDS](testcases/property/pass-if_multiple_properties_are_matched__all_values_must_satisfy_requirements_1_2.ids) - [Sample IFC: 7](testcases/property/pass-if_multiple_properties_are_matched__all_values_must_satisfy_requirements_1_2.ifc)

## [FAIL] If multiple properties are matched, all values must satisfy requirements 2/2

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <xs:restriction base="xs:string">
      <xs:pattern value="Foo.*"/>
    </xs:restriction>
  </name>
  <value>
    <xs:restriction base="xs:string">
      <xs:enumeration value="x"/>
      <xs:enumeration value="y"/>
    </xs:restriction>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#11=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('z'),$);
~~~

[Sample IDS](testcases/property/fail-if_multiple_properties_are_matched__all_values_must_satisfy_requirements_2_2.ids) - [Sample IFC: 7](testcases/property/fail-if_multiple_properties_are_matched__all_values_must_satisfy_requirements_2_2.ifc)

## [FAIL] Measures are used to specify an IFC data type 1/2

~~~xml
<property datatype="IFCTIMEMEASURE" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>2</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#5,#4,#2));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCMASSMEASURE(2.),$);
~~~

[Sample IDS](testcases/property/fail-measures_are_used_to_specify_an_ifc_data_type_1_2.ids) - [Sample IFC: 7](testcases/property/fail-measures_are_used_to_specify_an_ifc_data_type_1_2.ifc)

## [PASS] Measures are used to specify an IFC data type 2/2

~~~xml
<property datatype="IFCTIMEMEASURE" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>2</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#5,#4,#2));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCTIMEMEASURE(2.),$);
~~~

[Sample IDS](testcases/property/pass-measures_are_used_to_specify_an_ifc_data_type_2_2.ids) - [Sample IFC: 7](testcases/property/pass-measures_are_used_to_specify_an_ifc_data_type_2_2.ifc)

## [FAIL] Unit conversions shall take place to IDS-nominated standard units 1/2

~~~xml
<property datatype="IFCLENGTHMEASURE" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>2</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLENGTHMEASURE(2.),$);
~~~

[Sample IDS](testcases/property/fail-unit_conversions_shall_take_place_to_ids_nominated_standard_units_1_2.ids) - [Sample IFC: 7](testcases/property/fail-unit_conversions_shall_take_place_to_ids_nominated_standard_units_1_2.ifc)

## [PASS] Unit conversions shall take place to IDS-nominated standard units 2/2

~~~xml
<property datatype="IFCLENGTHMEASURE" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>2</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('16MocU_IDOF8_x3Iqllz0d',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLENGTHMEASURE(2000.),$);
~~~

[Sample IDS](testcases/property/pass-unit_conversions_shall_take_place_to_ids_nominated_standard_units_2_2.ids) - [Sample IFC: 7](testcases/property/pass-unit_conversions_shall_take_place_to_ids_nominated_standard_units_2_2.ifc)

## [PASS] Properties can be inherited from the type 1/2

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#5,#4,#2));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCWALLTYPE('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,(#10),$,$,$,.NOTDEFINED.);
#9=IFCRELDEFINESBYTYPE('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSET('0WTUhjMwvT39YBFH2pryoM',$,'Foo_Bar',$,(#11));
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-properties_can_be_inherited_from_the_type_1_2.ids) - [Sample IFC: 7](testcases/property/pass-properties_can_be_inherited_from_the_type_1_2.ifc)

## [PASS] Properties can be inherited from the type 2/2

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#3,#5,#4,#2));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#8=IFCWALLTYPE('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,(#10),$,$,$,.NOTDEFINED.); /* Testcase */
#9=IFCRELDEFINESBYTYPE('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSET('0WTUhjMwvT39YBFH2pryoM',$,'Foo_Bar',$,(#11));
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-properties_can_be_inherited_from_the_type_2_2.ids) - [Sample IFC: 8](testcases/property/pass-properties_can_be_inherited_from_the_type_2_2.ifc)

## [PASS] Properties can be overriden by an occurrence 1/2

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>Bar</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#3,#5));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCWALLTYPE('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,(#10),$,$,$,.NOTDEFINED.);
#9=IFCRELDEFINESBYTYPE('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSET('0WTUhjMwvT39YBFH2pryoM',$,'Foo_Bar',$,(#11));
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Baz'),$);
#12=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#14));
#13=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#7),#12);
#14=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-properties_can_be_overriden_by_an_occurrence_1_2.ids) - [Sample IFC: 7](testcases/property/pass-properties_can_be_overriden_by_an_occurrence_1_2.ifc)

## [FAIL] Properties can be overriden by an occurrence 2/2

~~~xml
<property datatype="IFCLABEL" maxOccurs="unbounded" minOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>Bar</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('1hqIFTRjfV6AWq_bMtnZwI',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#3,#5));
#7=IFCWALL('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,$);
#8=IFCWALLTYPE('16MocU_IDOF8_x3Iqllz0d',$,$,$,$,(#10),$,$,$,.NOTDEFINED.); /* Testcase */
#9=IFCRELDEFINESBYTYPE('1xdwj8qGXK4hzoNbvMdXJW',$,$,$,(#7),#8);
#10=IFCPROPERTYSET('0WTUhjMwvT39YBFH2pryoM',$,'Foo_Bar',$,(#11));
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Baz'),$);
#12=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#14));
#13=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#7),#12);
#14=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/fail-properties_can_be_overriden_by_an_occurrence_2_2.ids) - [Sample IFC: 8](testcases/property/fail-properties_can_be_overriden_by_an_occurrence_2_2.ifc)

