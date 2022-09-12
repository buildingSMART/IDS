# Property testcases

These testcases are designed to help describe behaviour in edge cases and ambiguities. All valid IDS implementations must demonstrate identical behaviour to these test cases.

## [FAIL] Elements with no properties always fail

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/property/fail-elements_with_no_properties_always_fail.ids) - [Sample IFC: 7](testcases/property/fail-elements_with_no_properties_always_fail.ifc)

## [FAIL] Elements with a matching pset but no property also fail

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
~~~

[Sample IDS](testcases/property/fail-elements_with_a_matching_pset_but_no_property_also_fail.ids) - [Sample IFC: 7](testcases/property/fail-elements_with_a_matching_pset_but_no_property_also_fail.ifc)

## [FAIL] Properties with a null value fail

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
~~~

[Sample IDS](testcases/property/fail-properties_with_a_null_value_fail.ids) - [Sample IFC: 7](testcases/property/fail-properties_with_a_null_value_fail.ifc)

## [PASS] A name check will match any property with any string value

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-a_name_check_will_match_any_property_with_any_string_value.ids) - [Sample IFC: 7](testcases/property/pass-a_name_check_will_match_any_property_with_any_string_value.ifc)

## [PASS] A required facet checks all parameters as normal

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$); /* Testcase */
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-a_required_facet_checks_all_parameters_as_normal.ids) - [Sample IFC: 12](testcases/property/pass-a_required_facet_checks_all_parameters_as_normal.ifc)

## [FAIL] A prohibited facet returns the opposite of a required facet

~~~xml
<property measure="IfcLabel" minOccurs="0" maxOccurs="0">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$); /* Testcase */
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/fail-a_prohibited_facet_returns_the_opposite_of_a_required_facet.ids) - [Sample IFC: 12](testcases/property/fail-a_prohibited_facet_returns_the_opposite_of_a_required_facet.ifc)

## [PASS] An optional facet always passes regardless of outcome 1/2

~~~xml
<property measure="IfcLabel" minOccurs="0" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$); /* Testcase */
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-an_optional_facet_always_passes_regardless_of_outcome_1_2.ids) - [Sample IFC: 12](testcases/property/pass-an_optional_facet_always_passes_regardless_of_outcome_1_2.ifc)

## [PASS] An optional facet always passes regardless of outcome 2/2

~~~xml
<property measure="IfcLabel" minOccurs="0" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Bar</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$); /* Testcase */
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-an_optional_facet_always_passes_regardless_of_outcome_2_2.ids) - [Sample IFC: 12](testcases/property/pass-an_optional_facet_always_passes_regardless_of_outcome_2_2.ifc)

## [FAIL] An empty string is considered falsey and will not pass

~~~xml
<property measure="IfcLogical" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$); /* Testcase */
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL(''),$);
~~~

[Sample IDS](testcases/property/fail-an_empty_string_is_considered_falsey_and_will_not_pass.ids) - [Sample IFC: 12](testcases/property/fail-an_empty_string_is_considered_falsey_and_will_not_pass.ifc)

## [FAIL] A logical unknown is considered falsey and will not pass

~~~xml
<property measure="IfcDuration" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$); /* Testcase */
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLOGICAL(.U.),$);
~~~

[Sample IDS](testcases/property/fail-a_logical_unknown_is_considered_falsey_and_will_not_pass.ids) - [Sample IFC: 12](testcases/property/fail-a_logical_unknown_is_considered_falsey_and_will_not_pass.ifc)

## [PASS] A zero duration will pass

~~~xml
<property measure="IfcDuration" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$); /* Testcase */
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P0D'),$);
~~~

[Sample IDS](testcases/property/pass-a_zero_duration_will_pass.ids) - [Sample IFC: 12](testcases/property/pass-a_zero_duration_will_pass.ifc)

## [PASS] A property set to true will pass a name check

~~~xml
<property measure="IfcBoolean" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$); /* Testcase */
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.T.),$);
~~~

[Sample IDS](testcases/property/pass-a_property_set_to_true_will_pass_a_name_check.ids) - [Sample IFC: 12](testcases/property/pass-a_property_set_to_true_will_pass_a_name_check.ifc)

## [PASS] A property set to false is still considered a value and will pass a name check

~~~xml
<property measure="IfcBoolean" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$); /* Testcase */
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
~~~

[Sample IDS](testcases/property/pass-a_property_set_to_false_is_still_considered_a_value_and_will_pass_a_name_check.ids) - [Sample IFC: 12](testcases/property/pass-a_property_set_to_false_is_still_considered_a_value_and_will_pass_a_name_check.ifc)

## [PASS] Specifying a value performs a case-sensitive match 1/2

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-specifying_a_value_performs_a_case_sensitive_match_1_2.ids) - [Sample IFC: 16](testcases/property/pass-specifying_a_value_performs_a_case_sensitive_match_1_2.ifc)

## [FAIL] Specifying a value performs a case-sensitive match 2/2

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('bar'),$);
~~~

[Sample IDS](testcases/property/fail-specifying_a_value_performs_a_case_sensitive_match_2_2.ids) - [Sample IFC: 16](testcases/property/fail-specifying_a_value_performs_a_case_sensitive_match_2_2.ifc)

## [FAIL] Specifying a value fails against different values

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Baz'),$);
~~~

[Sample IDS](testcases/property/fail-specifying_a_value_fails_against_different_values.ids) - [Sample IFC: 16](testcases/property/fail-specifying_a_value_fails_against_different_values.ifc)

## [PASS] Non-ascii characters are treated without encoding

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
  <value>
    <simpleValue>♫</simpleValue>
  </value>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('\X2\266B\X0\'),$);
~~~

[Sample IDS](testcases/property/pass-non_ascii_characters_are_treated_without_encoding.ids) - [Sample IFC: 16](testcases/property/pass-non_ascii_characters_are_treated_without_encoding.ifc)

## [FAIL] IDS does not handle string truncation such as for identifiers

~~~xml
<property measure="IfcIdentifier" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
~~~

[Sample IDS](testcases/property/fail-ids_does_not_handle_string_truncation_such_as_for_identifiers.ids) - [Sample IFC: 16](testcases/property/fail-ids_does_not_handle_string_truncation_such_as_for_identifiers.ifc)

## [PASS] A number specified as a string is treated as a string

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('1'),$);
~~~

[Sample IDS](testcases/property/pass-a_number_specified_as_a_string_is_treated_as_a_string.ids) - [Sample IFC: 20](testcases/property/pass-a_number_specified_as_a_string_is_treated_as_a_string.ifc)

## [PASS] Integer values are checked using type casting 1/4

~~~xml
<property measure="IfcInteger" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCINTEGER(42),$);
~~~

[Sample IDS](testcases/property/pass-integer_values_are_checked_using_type_casting_1_4.ids) - [Sample IFC: 20](testcases/property/pass-integer_values_are_checked_using_type_casting_1_4.ifc)

## [PASS] Integer values are checked using type casting 2/4

~~~xml
<property measure="IfcInteger" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCINTEGER(42),$);
~~~

[Sample IDS](testcases/property/pass-integer_values_are_checked_using_type_casting_2_4.ids) - [Sample IFC: 20](testcases/property/pass-integer_values_are_checked_using_type_casting_2_4.ifc)

## [PASS] Integer values are checked using type casting 3/4

~~~xml
<property measure="IfcInteger" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCINTEGER(42),$);
~~~

[Sample IDS](testcases/property/pass-integer_values_are_checked_using_type_casting_3_4.ids) - [Sample IFC: 20](testcases/property/pass-integer_values_are_checked_using_type_casting_3_4.ifc)

## [FAIL] Integer values are checked using type casting 4/4

~~~xml
<property measure="IfcInteger" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCINTEGER(42),$);
~~~

[Sample IDS](testcases/property/fail-integer_values_are_checked_using_type_casting_4_4.ids) - [Sample IFC: 20](testcases/property/fail-integer_values_are_checked_using_type_casting_4_4.ifc)

## [PASS] Real values are checked using type casting 1/3

~~~xml
<property measure="IfcReal" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(42.),$);
~~~

[Sample IDS](testcases/property/pass-real_values_are_checked_using_type_casting_1_3.ids) - [Sample IFC: 20](testcases/property/pass-real_values_are_checked_using_type_casting_1_3.ifc)

## [PASS] Real values are checked using type casting 2/3

~~~xml
<property measure="IfcReal" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(42.),$);
~~~

[Sample IDS](testcases/property/pass-real_values_are_checked_using_type_casting_2_3.ids) - [Sample IFC: 20](testcases/property/pass-real_values_are_checked_using_type_casting_2_3.ifc)

## [PASS] Real values are checked using type casting 3/3

~~~xml
<property measure="IfcReal" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(42.3),$);
~~~

[Sample IDS](testcases/property/pass-real_values_are_checked_using_type_casting_3_3.ids) - [Sample IFC: 20](testcases/property/pass-real_values_are_checked_using_type_casting_3_3.ifc)

## [FAIL] Only specifically formatted numbers are allowed 1/4

~~~xml
<property measure="IfcReal" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(42.3),$);
~~~

[Sample IDS](testcases/property/fail-only_specifically_formatted_numbers_are_allowed_1_4.ids) - [Sample IFC: 20](testcases/property/fail-only_specifically_formatted_numbers_are_allowed_1_4.ifc)

## [FAIL] Only specifically formatted numbers are allowed 2/4

~~~xml
<property measure="IfcReal" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(1234.5),$);
~~~

[Sample IDS](testcases/property/fail-only_specifically_formatted_numbers_are_allowed_2_4.ids) - [Sample IFC: 20](testcases/property/fail-only_specifically_formatted_numbers_are_allowed_2_4.ifc)

## [PASS] Only specifically formatted numbers are allowed 3/4

~~~xml
<property measure="IfcReal" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(1234.5),$);
~~~

[Sample IDS](testcases/property/pass-only_specifically_formatted_numbers_are_allowed_3_4.ids) - [Sample IFC: 20](testcases/property/pass-only_specifically_formatted_numbers_are_allowed_3_4.ifc)

## [PASS] Only specifically formatted numbers are allowed 4/4

~~~xml
<property measure="IfcReal" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(1234.5),$);
~~~

[Sample IDS](testcases/property/pass-only_specifically_formatted_numbers_are_allowed_4_4.ids) - [Sample IFC: 20](testcases/property/pass-only_specifically_formatted_numbers_are_allowed_4_4.ifc)

## [PASS] Floating point numbers are compared with a 1e-6 tolerance 1/4

~~~xml
<property measure="IfcReal" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(42.000042),$);
~~~

[Sample IDS](testcases/property/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_1_4.ids) - [Sample IFC: 20](testcases/property/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_1_4.ifc)

## [PASS] Floating point numbers are compared with a 1e-6 tolerance 2/4

~~~xml
<property measure="IfcReal" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(41.999958),$);
~~~

[Sample IDS](testcases/property/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_2_4.ids) - [Sample IFC: 20](testcases/property/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_2_4.ifc)

## [FAIL] Floating point numbers are compared with a 1e-6 tolerance 3/4

~~~xml
<property measure="IfcReal" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(42.000084),$);
~~~

[Sample IDS](testcases/property/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_3_4.ids) - [Sample IFC: 20](testcases/property/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_3_4.ifc)

## [FAIL] Floating point numbers are compared with a 1e-6 tolerance 4/4

~~~xml
<property measure="IfcReal" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(41.999916),$);
~~~

[Sample IDS](testcases/property/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_4_4.ids) - [Sample IFC: 20](testcases/property/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_4_4.ifc)

## [FAIL] Booleans must be specified as uppercase strings 1/3

~~~xml
<property measure="IfcBoolean" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
~~~

[Sample IDS](testcases/property/fail-booleans_must_be_specified_as_uppercase_strings_1_3.ids) - [Sample IFC: 20](testcases/property/fail-booleans_must_be_specified_as_uppercase_strings_1_3.ifc)

## [PASS] Booleans must be specified as uppercase strings 2/3

~~~xml
<property measure="IfcBoolean" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
~~~

[Sample IDS](testcases/property/pass-booleans_must_be_specified_as_uppercase_strings_2_3.ids) - [Sample IFC: 20](testcases/property/pass-booleans_must_be_specified_as_uppercase_strings_2_3.ifc)

## [FAIL] Booleans must be specified as uppercase strings 3/3

~~~xml
<property measure="IfcBoolean" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
~~~

[Sample IDS](testcases/property/fail-booleans_must_be_specified_as_uppercase_strings_3_3.ids) - [Sample IFC: 20](testcases/property/fail-booleans_must_be_specified_as_uppercase_strings_3_3.ifc)

## [PASS] Dates are treated as strings 1/2

~~~xml
<property measure="IfcDate" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDATE('2022-01-01'),$);
~~~

[Sample IDS](testcases/property/pass-dates_are_treated_as_strings_1_2.ids) - [Sample IFC: 20](testcases/property/pass-dates_are_treated_as_strings_1_2.ifc)

## [FAIL] Dates are treated as strings 2/2

~~~xml
<property measure="IfcDate" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDATE('2022-01-01+00:00'),$);
~~~

[Sample IDS](testcases/property/fail-dates_are_treated_as_strings_2_2.ids) - [Sample IFC: 20](testcases/property/fail-dates_are_treated_as_strings_2_2.ifc)

## [PASS] Durations are treated as strings 1/2

~~~xml
<property measure="IfcDuration" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('PT16H'),$);
~~~

[Sample IDS](testcases/property/pass-durations_are_treated_as_strings_1_2.ids) - [Sample IFC: 20](testcases/property/pass-durations_are_treated_as_strings_1_2.ifc)

## [FAIL] Durations are treated as strings 1/2

~~~xml
<property measure="IfcDuration" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
~~~

[Sample IDS](testcases/property/fail-durations_are_treated_as_strings_1_2.ids) - [Sample IFC: 20](testcases/property/fail-durations_are_treated_as_strings_1_2.ifc)

## [PASS] Any matching value in an enumerated property will pass 1/3

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$); /* Testcase */
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
~~~

[Sample IDS](testcases/property/pass-any_matching_value_in_an_enumerated_property_will_pass_1_3.ids) - [Sample IFC: 24](testcases/property/pass-any_matching_value_in_an_enumerated_property_will_pass_1_3.ifc)

## [PASS] Any matching value in an enumerated property will pass 2/3

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$); /* Testcase */
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
~~~

[Sample IDS](testcases/property/pass-any_matching_value_in_an_enumerated_property_will_pass_2_3.ids) - [Sample IFC: 24](testcases/property/pass-any_matching_value_in_an_enumerated_property_will_pass_2_3.ifc)

## [FAIL] Any matching value in an enumerated property will pass 3/3

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$); /* Testcase */
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
~~~

[Sample IDS](testcases/property/fail-any_matching_value_in_an_enumerated_property_will_pass_3_3.ids) - [Sample IFC: 24](testcases/property/fail-any_matching_value_in_an_enumerated_property_will_pass_3_3.ifc)

## [PASS] Any matching value in a list property will pass 1/3

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$); /* Testcase */
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
~~~

[Sample IDS](testcases/property/pass-any_matching_value_in_a_list_property_will_pass_1_3.ids) - [Sample IFC: 29](testcases/property/pass-any_matching_value_in_a_list_property_will_pass_1_3.ifc)

## [PASS] Any matching value in a list property will pass 2/3

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$); /* Testcase */
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
~~~

[Sample IDS](testcases/property/pass-any_matching_value_in_a_list_property_will_pass_2_3.ids) - [Sample IFC: 29](testcases/property/pass-any_matching_value_in_a_list_property_will_pass_2_3.ifc)

## [FAIL] Any matching value in a list property will pass 3/3

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$); /* Testcase */
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
~~~

[Sample IDS](testcases/property/fail-any_matching_value_in_a_list_property_will_pass_3_3.ids) - [Sample IFC: 29](testcases/property/fail-any_matching_value_in_a_list_property_will_pass_3_3.ifc)

## [PASS] Any matching value in a bounded property will pass 1/4

~~~xml
<property measure="IfcLengthMeasure" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$); /* Testcase */
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
~~~

[Sample IDS](testcases/property/pass-any_matching_value_in_a_bounded_property_will_pass_1_4.ids) - [Sample IFC: 33](testcases/property/pass-any_matching_value_in_a_bounded_property_will_pass_1_4.ifc)

## [PASS] Any matching value in a bounded property will pass 2/4

~~~xml
<property measure="IfcLengthMeasure" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$); /* Testcase */
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
~~~

[Sample IDS](testcases/property/pass-any_matching_value_in_a_bounded_property_will_pass_2_4.ids) - [Sample IFC: 33](testcases/property/pass-any_matching_value_in_a_bounded_property_will_pass_2_4.ifc)

## [PASS] Any matching value in a bounded property will pass 3/4

~~~xml
<property measure="IfcLengthMeasure" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$); /* Testcase */
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
~~~

[Sample IDS](testcases/property/pass-any_matching_value_in_a_bounded_property_will_pass_3_4.ids) - [Sample IFC: 33](testcases/property/pass-any_matching_value_in_a_bounded_property_will_pass_3_4.ifc)

## [FAIL] Any matching value in a bounded property will pass 4/4

~~~xml
<property measure="IfcLengthMeasure" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$); /* Testcase */
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
~~~

[Sample IDS](testcases/property/fail-any_matching_value_in_a_bounded_property_will_pass_4_4.ids) - [Sample IFC: 33](testcases/property/fail-any_matching_value_in_a_bounded_property_will_pass_4_4.ifc)

## [PASS] Any matching value in a table property will pass 1/3

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$); /* Testcase */
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
~~~

[Sample IDS](testcases/property/pass-any_matching_value_in_a_table_property_will_pass_1_3.ids) - [Sample IFC: 37](testcases/property/pass-any_matching_value_in_a_table_property_will_pass_1_3.ifc)

## [PASS] Any matching value in a table property will pass 2/3

~~~xml
<property measure="IfcLengthMeasure" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$); /* Testcase */
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
~~~

[Sample IDS](testcases/property/pass-any_matching_value_in_a_table_property_will_pass_2_3.ids) - [Sample IFC: 37](testcases/property/pass-any_matching_value_in_a_table_property_will_pass_2_3.ifc)

## [FAIL] Any matching value in a table property will pass 3/3

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$); /* Testcase */
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
~~~

[Sample IDS](testcases/property/fail-any_matching_value_in_a_table_property_will_pass_3_3.ids) - [Sample IFC: 37](testcases/property/fail-any_matching_value_in_a_table_property_will_pass_3_3.ifc)

## [FAIL] Reference properties are treated as objects and not supported

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$); /* Testcase */
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
~~~

[Sample IDS](testcases/property/fail-reference_properties_are_treated_as_objects_and_not_supported.ids) - [Sample IFC: 41](testcases/property/fail-reference_properties_are_treated_as_objects_and_not_supported.ifc)

## [PASS] Predefined properties are supported but discouraged 1/2

~~~xml
<property measure="IfcDoorPanelOperationEnum" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$); /* Testcase */
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
~~~

[Sample IDS](testcases/property/pass-predefined_properties_are_supported_but_discouraged_1_2.ids) - [Sample IFC: 45](testcases/property/pass-predefined_properties_are_supported_but_discouraged_1_2.ifc)

## [FAIL] Predefined properties are supported but discouraged 2/2

~~~xml
<property measure="IfcDoorPanelOperationEnum" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$); /* Testcase */
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
~~~

[Sample IDS](testcases/property/fail-predefined_properties_are_supported_but_discouraged_2_2.ids) - [Sample IFC: 45](testcases/property/fail-predefined_properties_are_supported_but_discouraged_2_2.ifc)

## [PASS] A name check will match any quantity with any value

~~~xml
<property measure="IfcLengthMeasure" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$); /* Testcase */
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
~~~

[Sample IDS](testcases/property/pass-a_name_check_will_match_any_quantity_with_any_value.ids) - [Sample IFC: 48](testcases/property/pass-a_name_check_will_match_any_quantity_with_any_value.ifc)

## [FAIL] Quantities must also match the appropriate measure

~~~xml
<property measure="IfcAreaMeasure" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$); /* Testcase */
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
~~~

[Sample IDS](testcases/property/fail-quantities_must_also_match_the_appropriate_measure.ids) - [Sample IFC: 48](testcases/property/fail-quantities_must_also_match_the_appropriate_measure.ifc)

## [FAIL] Complex properties are not supported 1/2

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$); /* Testcase */
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
~~~

[Sample IDS](testcases/property/fail-complex_properties_are_not_supported_1_2.ids) - [Sample IFC: 52](testcases/property/fail-complex_properties_are_not_supported_1_2.ifc)

## [FAIL] Complex properties are not supported 2/2

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Rabbits</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$); /* Testcase */
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
~~~

[Sample IDS](testcases/property/fail-complex_properties_are_not_supported_2_2.ids) - [Sample IFC: 52](testcases/property/fail-complex_properties_are_not_supported_2_2.ifc)

## [FAIL] Complex properties are not supported 1/2

~~~xml
<property measure="IfcLengthMeasure" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$);
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
#57=IFCWALL('06dBUGnorHr9WTofAidJHU',$,$,$,$,$,$,$,$); /* Testcase */
#58=IFCELEMENTQUANTITY('3AX9vL9EnKsugqFO9zvGI8',$,'Foo_Bar',$,$,(#60));
#59=IFCRELDEFINESBYPROPERTIES('1f2z3t2m1M_PU1dzQHWaTY',$,$,$,(#57),#58);
#60=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#61),'FurThickness',$,$);
#61=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
~~~

[Sample IDS](testcases/property/fail-complex_properties_are_not_supported_1_2.ids) - [Sample IFC: 57](testcases/property/fail-complex_properties_are_not_supported_1_2.ifc)

## [FAIL] Complex properties are not supported 2/2

~~~xml
<property measure="IfcLengthMeasure" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo</simpleValue>
  </propertySet>
  <name>
    <simpleValue>MyLength</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$);
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
#57=IFCWALL('06dBUGnorHr9WTofAidJHU',$,$,$,$,$,$,$,$); /* Testcase */
#58=IFCELEMENTQUANTITY('3AX9vL9EnKsugqFO9zvGI8',$,'Foo_Bar',$,$,(#60));
#59=IFCRELDEFINESBYPROPERTIES('1f2z3t2m1M_PU1dzQHWaTY',$,$,$,(#57),#58);
#60=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#61),'FurThickness',$,$);
#61=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
~~~

[Sample IDS](testcases/property/fail-complex_properties_are_not_supported_2_2.ids) - [Sample IFC: 57](testcases/property/fail-complex_properties_are_not_supported_2_2.ifc)

## [PASS] All matching property sets must satisfy requirements 1/3

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$);
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
#57=IFCWALL('06dBUGnorHr9WTofAidJHU',$,$,$,$,$,$,$,$);
#58=IFCELEMENTQUANTITY('3AX9vL9EnKsugqFO9zvGI8',$,'Foo_Bar',$,$,(#60));
#59=IFCRELDEFINESBYPROPERTIES('1f2z3t2m1M_PU1dzQHWaTY',$,$,$,(#57),#58);
#60=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#61),'FurThickness',$,$);
#61=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
#62=IFCWALL('0L0eAFgLXNmQCI$MkB3EKH',$,$,$,$,$,$,$,$); /* Testcase */
#63=IFCPROPERTYSET('1HUXyD$vHLSuOw2lJ4CGK1',$,'Foo_Bar',$,(#65));
#64=IFCRELDEFINESBYPROPERTIES('35ZNU4RLPSjQvdV$voX4wj',$,$,$,(#62),#63);
#65=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-all_matching_property_sets_must_satisfy_requirements_1_3.ids) - [Sample IFC: 62](testcases/property/pass-all_matching_property_sets_must_satisfy_requirements_1_3.ifc)

## [FAIL] All matching property sets must satisfy requirements 2/3

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$);
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
#57=IFCWALL('06dBUGnorHr9WTofAidJHU',$,$,$,$,$,$,$,$);
#58=IFCELEMENTQUANTITY('3AX9vL9EnKsugqFO9zvGI8',$,'Foo_Bar',$,$,(#60));
#59=IFCRELDEFINESBYPROPERTIES('1f2z3t2m1M_PU1dzQHWaTY',$,$,$,(#57),#58);
#60=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#61),'FurThickness',$,$);
#61=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
#62=IFCWALL('0L0eAFgLXNmQCI$MkB3EKH',$,$,$,$,$,$,$,$); /* Testcase */
#63=IFCPROPERTYSET('1HUXyD$vHLSuOw2lJ4CGK1',$,'Foo_Bar',$,(#65));
#64=IFCRELDEFINESBYPROPERTIES('35ZNU4RLPSjQvdV$voX4wj',$,$,$,(#62),#63);
#65=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#66=IFCPROPERTYSET('3TYjDOTovQt9yfYD96b89K',$,'Foo_Baz',$,(#68));
#67=IFCRELDEFINESBYPROPERTIES('3mG97g3IDRxQTRsJyocvys',$,$,$,(#62),#66);
#68=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
~~~

[Sample IDS](testcases/property/fail-all_matching_property_sets_must_satisfy_requirements_2_3.ids) - [Sample IFC: 62](testcases/property/fail-all_matching_property_sets_must_satisfy_requirements_2_3.ifc)

## [PASS] All matching property sets must satisfy requirements 3/3

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$);
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
#57=IFCWALL('06dBUGnorHr9WTofAidJHU',$,$,$,$,$,$,$,$);
#58=IFCELEMENTQUANTITY('3AX9vL9EnKsugqFO9zvGI8',$,'Foo_Bar',$,$,(#60));
#59=IFCRELDEFINESBYPROPERTIES('1f2z3t2m1M_PU1dzQHWaTY',$,$,$,(#57),#58);
#60=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#61),'FurThickness',$,$);
#61=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
#62=IFCWALL('0L0eAFgLXNmQCI$MkB3EKH',$,$,$,$,$,$,$,$); /* Testcase */
#63=IFCPROPERTYSET('1HUXyD$vHLSuOw2lJ4CGK1',$,'Foo_Bar',$,(#65));
#64=IFCRELDEFINESBYPROPERTIES('35ZNU4RLPSjQvdV$voX4wj',$,$,$,(#62),#63);
#65=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#66=IFCPROPERTYSET('3TYjDOTovQt9yfYD96b89K',$,'Foo_Baz',$,(#68,#69));
#67=IFCRELDEFINESBYPROPERTIES('3mG97g3IDRxQTRsJyocvys',$,$,$,(#62),#66);
#68=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#69=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-all_matching_property_sets_must_satisfy_requirements_3_3.ids) - [Sample IFC: 62](testcases/property/pass-all_matching_property_sets_must_satisfy_requirements_3_3.ifc)

## [PASS] All matching properties must satisfy requirements 1/3

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$);
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
#57=IFCWALL('06dBUGnorHr9WTofAidJHU',$,$,$,$,$,$,$,$);
#58=IFCELEMENTQUANTITY('3AX9vL9EnKsugqFO9zvGI8',$,'Foo_Bar',$,$,(#60));
#59=IFCRELDEFINESBYPROPERTIES('1f2z3t2m1M_PU1dzQHWaTY',$,$,$,(#57),#58);
#60=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#61),'FurThickness',$,$);
#61=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
#62=IFCWALL('0L0eAFgLXNmQCI$MkB3EKH',$,$,$,$,$,$,$,$);
#63=IFCPROPERTYSET('1HUXyD$vHLSuOw2lJ4CGK1',$,'Foo_Bar',$,(#65));
#64=IFCRELDEFINESBYPROPERTIES('35ZNU4RLPSjQvdV$voX4wj',$,$,$,(#62),#63);
#65=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#66=IFCPROPERTYSET('3TYjDOTovQt9yfYD96b89K',$,'Foo_Baz',$,(#68,#69));
#67=IFCRELDEFINESBYPROPERTIES('3mG97g3IDRxQTRsJyocvys',$,$,$,(#62),#66);
#68=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#69=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#70=IFCWALL('3hmvEohnXRTBQcz0B8Km$H',$,$,$,$,$,$,$,$); /* Testcase */
#71=IFCPROPERTYSET('20M738grnLZgxtK88cIOjo',$,'Foo_Bar',$,(#73));
#72=IFCRELDEFINESBYPROPERTIES('3YEncJrUrHZOy4ZAVgD6_F',$,$,$,(#70),#71);
#73=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
~~~

[Sample IDS](testcases/property/pass-all_matching_properties_must_satisfy_requirements_1_3.ids) - [Sample IFC: 70](testcases/property/pass-all_matching_properties_must_satisfy_requirements_1_3.ifc)

## [PASS] All matching properties must satisfy requirements 2/3

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$);
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
#57=IFCWALL('06dBUGnorHr9WTofAidJHU',$,$,$,$,$,$,$,$);
#58=IFCELEMENTQUANTITY('3AX9vL9EnKsugqFO9zvGI8',$,'Foo_Bar',$,$,(#60));
#59=IFCRELDEFINESBYPROPERTIES('1f2z3t2m1M_PU1dzQHWaTY',$,$,$,(#57),#58);
#60=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#61),'FurThickness',$,$);
#61=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
#62=IFCWALL('0L0eAFgLXNmQCI$MkB3EKH',$,$,$,$,$,$,$,$);
#63=IFCPROPERTYSET('1HUXyD$vHLSuOw2lJ4CGK1',$,'Foo_Bar',$,(#65));
#64=IFCRELDEFINESBYPROPERTIES('35ZNU4RLPSjQvdV$voX4wj',$,$,$,(#62),#63);
#65=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#66=IFCPROPERTYSET('3TYjDOTovQt9yfYD96b89K',$,'Foo_Baz',$,(#68,#69));
#67=IFCRELDEFINESBYPROPERTIES('3mG97g3IDRxQTRsJyocvys',$,$,$,(#62),#66);
#68=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#69=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#70=IFCWALL('3hmvEohnXRTBQcz0B8Km$H',$,$,$,$,$,$,$,$); /* Testcase */
#71=IFCPROPERTYSET('20M738grnLZgxtK88cIOjo',$,'Foo_Bar',$,(#73,#74));
#72=IFCRELDEFINESBYPROPERTIES('3YEncJrUrHZOy4ZAVgD6_F',$,$,$,(#70),#71);
#73=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#74=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('x'),$);
~~~

[Sample IDS](testcases/property/pass-all_matching_properties_must_satisfy_requirements_2_3.ids) - [Sample IFC: 70](testcases/property/pass-all_matching_properties_must_satisfy_requirements_2_3.ifc)

## [FAIL] All matching properties must satisfy requirements 3/3

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$);
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
#57=IFCWALL('06dBUGnorHr9WTofAidJHU',$,$,$,$,$,$,$,$);
#58=IFCELEMENTQUANTITY('3AX9vL9EnKsugqFO9zvGI8',$,'Foo_Bar',$,$,(#60));
#59=IFCRELDEFINESBYPROPERTIES('1f2z3t2m1M_PU1dzQHWaTY',$,$,$,(#57),#58);
#60=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#61),'FurThickness',$,$);
#61=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
#62=IFCWALL('0L0eAFgLXNmQCI$MkB3EKH',$,$,$,$,$,$,$,$);
#63=IFCPROPERTYSET('1HUXyD$vHLSuOw2lJ4CGK1',$,'Foo_Bar',$,(#65));
#64=IFCRELDEFINESBYPROPERTIES('35ZNU4RLPSjQvdV$voX4wj',$,$,$,(#62),#63);
#65=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#66=IFCPROPERTYSET('3TYjDOTovQt9yfYD96b89K',$,'Foo_Baz',$,(#68,#69));
#67=IFCRELDEFINESBYPROPERTIES('3mG97g3IDRxQTRsJyocvys',$,$,$,(#62),#66);
#68=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#69=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#70=IFCWALL('3hmvEohnXRTBQcz0B8Km$H',$,$,$,$,$,$,$,$); /* Testcase */
#71=IFCPROPERTYSET('20M738grnLZgxtK88cIOjo',$,'Foo_Bar',$,(#73,#74));
#72=IFCRELDEFINESBYPROPERTIES('3YEncJrUrHZOy4ZAVgD6_F',$,$,$,(#70),#71);
#73=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#74=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
~~~

[Sample IDS](testcases/property/fail-all_matching_properties_must_satisfy_requirements_3_3.ids) - [Sample IFC: 70](testcases/property/fail-all_matching_properties_must_satisfy_requirements_3_3.ifc)

## [PASS] If multiple properties are matched, all values must satisfy requirements 1/2

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$);
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
#57=IFCWALL('06dBUGnorHr9WTofAidJHU',$,$,$,$,$,$,$,$);
#58=IFCELEMENTQUANTITY('3AX9vL9EnKsugqFO9zvGI8',$,'Foo_Bar',$,$,(#60));
#59=IFCRELDEFINESBYPROPERTIES('1f2z3t2m1M_PU1dzQHWaTY',$,$,$,(#57),#58);
#60=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#61),'FurThickness',$,$);
#61=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
#62=IFCWALL('0L0eAFgLXNmQCI$MkB3EKH',$,$,$,$,$,$,$,$);
#63=IFCPROPERTYSET('1HUXyD$vHLSuOw2lJ4CGK1',$,'Foo_Bar',$,(#65));
#64=IFCRELDEFINESBYPROPERTIES('35ZNU4RLPSjQvdV$voX4wj',$,$,$,(#62),#63);
#65=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#66=IFCPROPERTYSET('3TYjDOTovQt9yfYD96b89K',$,'Foo_Baz',$,(#68,#69));
#67=IFCRELDEFINESBYPROPERTIES('3mG97g3IDRxQTRsJyocvys',$,$,$,(#62),#66);
#68=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#69=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#70=IFCWALL('3hmvEohnXRTBQcz0B8Km$H',$,$,$,$,$,$,$,$);
#71=IFCPROPERTYSET('20M738grnLZgxtK88cIOjo',$,'Foo_Bar',$,(#73,#74));
#72=IFCRELDEFINESBYPROPERTIES('3YEncJrUrHZOy4ZAVgD6_F',$,$,$,(#70),#71);
#73=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#74=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#75=IFCWALL('0EkiHYiyjLpQNvH88aN_jG',$,$,$,$,$,$,$,$); /* Testcase */
#76=IFCPROPERTYSET('37dCRfl7zH8u_UMgpfwkN4',$,'Foo_Bar',$,(#78,#79));
#77=IFCRELDEFINESBYPROPERTIES('38ScSfV8vIxvdFIY_OpbuR',$,$,$,(#75),#76);
#78=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#79=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
~~~

[Sample IDS](testcases/property/pass-if_multiple_properties_are_matched__all_values_must_satisfy_requirements_1_2.ids) - [Sample IFC: 75](testcases/property/pass-if_multiple_properties_are_matched__all_values_must_satisfy_requirements_1_2.ifc)

## [FAIL] If multiple properties are matched, all values must satisfy requirements 2/2

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$);
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
#57=IFCWALL('06dBUGnorHr9WTofAidJHU',$,$,$,$,$,$,$,$);
#58=IFCELEMENTQUANTITY('3AX9vL9EnKsugqFO9zvGI8',$,'Foo_Bar',$,$,(#60));
#59=IFCRELDEFINESBYPROPERTIES('1f2z3t2m1M_PU1dzQHWaTY',$,$,$,(#57),#58);
#60=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#61),'FurThickness',$,$);
#61=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
#62=IFCWALL('0L0eAFgLXNmQCI$MkB3EKH',$,$,$,$,$,$,$,$);
#63=IFCPROPERTYSET('1HUXyD$vHLSuOw2lJ4CGK1',$,'Foo_Bar',$,(#65));
#64=IFCRELDEFINESBYPROPERTIES('35ZNU4RLPSjQvdV$voX4wj',$,$,$,(#62),#63);
#65=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#66=IFCPROPERTYSET('3TYjDOTovQt9yfYD96b89K',$,'Foo_Baz',$,(#68,#69));
#67=IFCRELDEFINESBYPROPERTIES('3mG97g3IDRxQTRsJyocvys',$,$,$,(#62),#66);
#68=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#69=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#70=IFCWALL('3hmvEohnXRTBQcz0B8Km$H',$,$,$,$,$,$,$,$);
#71=IFCPROPERTYSET('20M738grnLZgxtK88cIOjo',$,'Foo_Bar',$,(#73,#74));
#72=IFCRELDEFINESBYPROPERTIES('3YEncJrUrHZOy4ZAVgD6_F',$,$,$,(#70),#71);
#73=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#74=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#75=IFCWALL('0EkiHYiyjLpQNvH88aN_jG',$,$,$,$,$,$,$,$); /* Testcase */
#76=IFCPROPERTYSET('37dCRfl7zH8u_UMgpfwkN4',$,'Foo_Bar',$,(#78,#79));
#77=IFCRELDEFINESBYPROPERTIES('38ScSfV8vIxvdFIY_OpbuR',$,$,$,(#75),#76);
#78=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#79=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('z'),$);
~~~

[Sample IDS](testcases/property/fail-if_multiple_properties_are_matched__all_values_must_satisfy_requirements_2_2.ids) - [Sample IFC: 75](testcases/property/fail-if_multiple_properties_are_matched__all_values_must_satisfy_requirements_2_2.ifc)

## [FAIL] Measures are used to specify an IFC data type 1/2

~~~xml
<property measure="IfcTimeMeasure" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$);
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
#57=IFCWALL('06dBUGnorHr9WTofAidJHU',$,$,$,$,$,$,$,$);
#58=IFCELEMENTQUANTITY('3AX9vL9EnKsugqFO9zvGI8',$,'Foo_Bar',$,$,(#60));
#59=IFCRELDEFINESBYPROPERTIES('1f2z3t2m1M_PU1dzQHWaTY',$,$,$,(#57),#58);
#60=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#61),'FurThickness',$,$);
#61=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
#62=IFCWALL('0L0eAFgLXNmQCI$MkB3EKH',$,$,$,$,$,$,$,$);
#63=IFCPROPERTYSET('1HUXyD$vHLSuOw2lJ4CGK1',$,'Foo_Bar',$,(#65));
#64=IFCRELDEFINESBYPROPERTIES('35ZNU4RLPSjQvdV$voX4wj',$,$,$,(#62),#63);
#65=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#66=IFCPROPERTYSET('3TYjDOTovQt9yfYD96b89K',$,'Foo_Baz',$,(#68,#69));
#67=IFCRELDEFINESBYPROPERTIES('3mG97g3IDRxQTRsJyocvys',$,$,$,(#62),#66);
#68=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#69=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#70=IFCWALL('3hmvEohnXRTBQcz0B8Km$H',$,$,$,$,$,$,$,$);
#71=IFCPROPERTYSET('20M738grnLZgxtK88cIOjo',$,'Foo_Bar',$,(#73,#74));
#72=IFCRELDEFINESBYPROPERTIES('3YEncJrUrHZOy4ZAVgD6_F',$,$,$,(#70),#71);
#73=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#74=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#75=IFCWALL('0EkiHYiyjLpQNvH88aN_jG',$,$,$,$,$,$,$,$);
#76=IFCPROPERTYSET('37dCRfl7zH8u_UMgpfwkN4',$,'Foo_Bar',$,(#78,#79));
#77=IFCRELDEFINESBYPROPERTIES('38ScSfV8vIxvdFIY_OpbuR',$,$,$,(#75),#76);
#78=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#79=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('z'),$);
#80=IFCWALL('1alyMlGcrTH8qJBDFp9$Tn',$,$,$,$,$,$,$,$); /* Testcase */
#81=IFCPROPERTYSET('2MfOkfqWfQSOo03vpufA6M',$,'Foo_Bar',$,(#83));
#82=IFCRELDEFINESBYPROPERTIES('17I6O4APPJbvyM6hy7zVLx',$,$,$,(#80),#81);
#83=IFCPROPERTYSINGLEVALUE('Foo',$,IFCMASSMEASURE(2.),$);
~~~

[Sample IDS](testcases/property/fail-measures_are_used_to_specify_an_ifc_data_type_1_2.ids) - [Sample IFC: 80](testcases/property/fail-measures_are_used_to_specify_an_ifc_data_type_1_2.ifc)

## [PASS] Measures are used to specify an IFC data type 2/2

~~~xml
<property measure="IfcTimeMeasure" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$);
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
#57=IFCWALL('06dBUGnorHr9WTofAidJHU',$,$,$,$,$,$,$,$);
#58=IFCELEMENTQUANTITY('3AX9vL9EnKsugqFO9zvGI8',$,'Foo_Bar',$,$,(#60));
#59=IFCRELDEFINESBYPROPERTIES('1f2z3t2m1M_PU1dzQHWaTY',$,$,$,(#57),#58);
#60=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#61),'FurThickness',$,$);
#61=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
#62=IFCWALL('0L0eAFgLXNmQCI$MkB3EKH',$,$,$,$,$,$,$,$);
#63=IFCPROPERTYSET('1HUXyD$vHLSuOw2lJ4CGK1',$,'Foo_Bar',$,(#65));
#64=IFCRELDEFINESBYPROPERTIES('35ZNU4RLPSjQvdV$voX4wj',$,$,$,(#62),#63);
#65=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#66=IFCPROPERTYSET('3TYjDOTovQt9yfYD96b89K',$,'Foo_Baz',$,(#68,#69));
#67=IFCRELDEFINESBYPROPERTIES('3mG97g3IDRxQTRsJyocvys',$,$,$,(#62),#66);
#68=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#69=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#70=IFCWALL('3hmvEohnXRTBQcz0B8Km$H',$,$,$,$,$,$,$,$);
#71=IFCPROPERTYSET('20M738grnLZgxtK88cIOjo',$,'Foo_Bar',$,(#73,#74));
#72=IFCRELDEFINESBYPROPERTIES('3YEncJrUrHZOy4ZAVgD6_F',$,$,$,(#70),#71);
#73=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#74=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#75=IFCWALL('0EkiHYiyjLpQNvH88aN_jG',$,$,$,$,$,$,$,$);
#76=IFCPROPERTYSET('37dCRfl7zH8u_UMgpfwkN4',$,'Foo_Bar',$,(#78,#79));
#77=IFCRELDEFINESBYPROPERTIES('38ScSfV8vIxvdFIY_OpbuR',$,$,$,(#75),#76);
#78=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#79=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('z'),$);
#80=IFCWALL('1alyMlGcrTH8qJBDFp9$Tn',$,$,$,$,$,$,$,$); /* Testcase */
#81=IFCPROPERTYSET('2MfOkfqWfQSOo03vpufA6M',$,'Foo_Bar',$,(#83));
#82=IFCRELDEFINESBYPROPERTIES('17I6O4APPJbvyM6hy7zVLx',$,$,$,(#80),#81);
#83=IFCPROPERTYSINGLEVALUE('Foo',$,IFCTIMEMEASURE(2.),$);
~~~

[Sample IDS](testcases/property/pass-measures_are_used_to_specify_an_ifc_data_type_2_2.ids) - [Sample IFC: 80](testcases/property/pass-measures_are_used_to_specify_an_ifc_data_type_2_2.ifc)

## [FAIL] Unit conversions shall take place to IDS-nominated standard units 1/2

~~~xml
<property measure="IfcLengthMeasure" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$);
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
#57=IFCWALL('06dBUGnorHr9WTofAidJHU',$,$,$,$,$,$,$,$);
#58=IFCELEMENTQUANTITY('3AX9vL9EnKsugqFO9zvGI8',$,'Foo_Bar',$,$,(#60));
#59=IFCRELDEFINESBYPROPERTIES('1f2z3t2m1M_PU1dzQHWaTY',$,$,$,(#57),#58);
#60=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#61),'FurThickness',$,$);
#61=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
#62=IFCWALL('0L0eAFgLXNmQCI$MkB3EKH',$,$,$,$,$,$,$,$);
#63=IFCPROPERTYSET('1HUXyD$vHLSuOw2lJ4CGK1',$,'Foo_Bar',$,(#65));
#64=IFCRELDEFINESBYPROPERTIES('35ZNU4RLPSjQvdV$voX4wj',$,$,$,(#62),#63);
#65=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#66=IFCPROPERTYSET('3TYjDOTovQt9yfYD96b89K',$,'Foo_Baz',$,(#68,#69));
#67=IFCRELDEFINESBYPROPERTIES('3mG97g3IDRxQTRsJyocvys',$,$,$,(#62),#66);
#68=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#69=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#70=IFCWALL('3hmvEohnXRTBQcz0B8Km$H',$,$,$,$,$,$,$,$);
#71=IFCPROPERTYSET('20M738grnLZgxtK88cIOjo',$,'Foo_Bar',$,(#73,#74));
#72=IFCRELDEFINESBYPROPERTIES('3YEncJrUrHZOy4ZAVgD6_F',$,$,$,(#70),#71);
#73=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#74=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#75=IFCWALL('0EkiHYiyjLpQNvH88aN_jG',$,$,$,$,$,$,$,$);
#76=IFCPROPERTYSET('37dCRfl7zH8u_UMgpfwkN4',$,'Foo_Bar',$,(#78,#79));
#77=IFCRELDEFINESBYPROPERTIES('38ScSfV8vIxvdFIY_OpbuR',$,$,$,(#75),#76);
#78=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#79=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('z'),$);
#80=IFCWALL('1alyMlGcrTH8qJBDFp9$Tn',$,$,$,$,$,$,$,$);
#81=IFCPROPERTYSET('2MfOkfqWfQSOo03vpufA6M',$,'Foo_Bar',$,(#83));
#82=IFCRELDEFINESBYPROPERTIES('17I6O4APPJbvyM6hy7zVLx',$,$,$,(#80),#81);
#83=IFCPROPERTYSINGLEVALUE('Foo',$,IFCTIMEMEASURE(2.),$);
#84=IFCWALL('0JHV6tGG1P89eeyxS772p$',$,$,$,$,$,$,$,$); /* Testcase */
#85=IFCPROPERTYSET('0rqo2fFffSSuedJDfGh4p6',$,'Foo_Bar',$,(#87));
#86=IFCRELDEFINESBYPROPERTIES('0182XiYTzPduj0OGf91UOP',$,$,$,(#84),#85);
#87=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLENGTHMEASURE(2.),$);
~~~

[Sample IDS](testcases/property/fail-unit_conversions_shall_take_place_to_ids_nominated_standard_units_1_2.ids) - [Sample IFC: 84](testcases/property/fail-unit_conversions_shall_take_place_to_ids_nominated_standard_units_1_2.ifc)

## [PASS] Unit conversions shall take place to IDS-nominated standard units 2/2

~~~xml
<property measure="IfcLengthMeasure" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$);
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
#57=IFCWALL('06dBUGnorHr9WTofAidJHU',$,$,$,$,$,$,$,$);
#58=IFCELEMENTQUANTITY('3AX9vL9EnKsugqFO9zvGI8',$,'Foo_Bar',$,$,(#60));
#59=IFCRELDEFINESBYPROPERTIES('1f2z3t2m1M_PU1dzQHWaTY',$,$,$,(#57),#58);
#60=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#61),'FurThickness',$,$);
#61=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
#62=IFCWALL('0L0eAFgLXNmQCI$MkB3EKH',$,$,$,$,$,$,$,$);
#63=IFCPROPERTYSET('1HUXyD$vHLSuOw2lJ4CGK1',$,'Foo_Bar',$,(#65));
#64=IFCRELDEFINESBYPROPERTIES('35ZNU4RLPSjQvdV$voX4wj',$,$,$,(#62),#63);
#65=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#66=IFCPROPERTYSET('3TYjDOTovQt9yfYD96b89K',$,'Foo_Baz',$,(#68,#69));
#67=IFCRELDEFINESBYPROPERTIES('3mG97g3IDRxQTRsJyocvys',$,$,$,(#62),#66);
#68=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#69=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#70=IFCWALL('3hmvEohnXRTBQcz0B8Km$H',$,$,$,$,$,$,$,$);
#71=IFCPROPERTYSET('20M738grnLZgxtK88cIOjo',$,'Foo_Bar',$,(#73,#74));
#72=IFCRELDEFINESBYPROPERTIES('3YEncJrUrHZOy4ZAVgD6_F',$,$,$,(#70),#71);
#73=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#74=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#75=IFCWALL('0EkiHYiyjLpQNvH88aN_jG',$,$,$,$,$,$,$,$);
#76=IFCPROPERTYSET('37dCRfl7zH8u_UMgpfwkN4',$,'Foo_Bar',$,(#78,#79));
#77=IFCRELDEFINESBYPROPERTIES('38ScSfV8vIxvdFIY_OpbuR',$,$,$,(#75),#76);
#78=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#79=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('z'),$);
#80=IFCWALL('1alyMlGcrTH8qJBDFp9$Tn',$,$,$,$,$,$,$,$);
#81=IFCPROPERTYSET('2MfOkfqWfQSOo03vpufA6M',$,'Foo_Bar',$,(#83));
#82=IFCRELDEFINESBYPROPERTIES('17I6O4APPJbvyM6hy7zVLx',$,$,$,(#80),#81);
#83=IFCPROPERTYSINGLEVALUE('Foo',$,IFCTIMEMEASURE(2.),$);
#84=IFCWALL('0JHV6tGG1P89eeyxS772p$',$,$,$,$,$,$,$,$); /* Testcase */
#85=IFCPROPERTYSET('0rqo2fFffSSuedJDfGh4p6',$,'Foo_Bar',$,(#87));
#86=IFCRELDEFINESBYPROPERTIES('0182XiYTzPduj0OGf91UOP',$,$,$,(#84),#85);
#87=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLENGTHMEASURE(2000.),$);
~~~

[Sample IDS](testcases/property/pass-unit_conversions_shall_take_place_to_ids_nominated_standard_units_2_2.ids) - [Sample IFC: 84](testcases/property/pass-unit_conversions_shall_take_place_to_ids_nominated_standard_units_2_2.ifc)

## [PASS] Properties can be inherited from the type 1/2

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$);
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
#57=IFCWALL('06dBUGnorHr9WTofAidJHU',$,$,$,$,$,$,$,$);
#58=IFCELEMENTQUANTITY('3AX9vL9EnKsugqFO9zvGI8',$,'Foo_Bar',$,$,(#60));
#59=IFCRELDEFINESBYPROPERTIES('1f2z3t2m1M_PU1dzQHWaTY',$,$,$,(#57),#58);
#60=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#61),'FurThickness',$,$);
#61=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
#62=IFCWALL('0L0eAFgLXNmQCI$MkB3EKH',$,$,$,$,$,$,$,$);
#63=IFCPROPERTYSET('1HUXyD$vHLSuOw2lJ4CGK1',$,'Foo_Bar',$,(#65));
#64=IFCRELDEFINESBYPROPERTIES('35ZNU4RLPSjQvdV$voX4wj',$,$,$,(#62),#63);
#65=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#66=IFCPROPERTYSET('3TYjDOTovQt9yfYD96b89K',$,'Foo_Baz',$,(#68,#69));
#67=IFCRELDEFINESBYPROPERTIES('3mG97g3IDRxQTRsJyocvys',$,$,$,(#62),#66);
#68=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#69=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#70=IFCWALL('3hmvEohnXRTBQcz0B8Km$H',$,$,$,$,$,$,$,$);
#71=IFCPROPERTYSET('20M738grnLZgxtK88cIOjo',$,'Foo_Bar',$,(#73,#74));
#72=IFCRELDEFINESBYPROPERTIES('3YEncJrUrHZOy4ZAVgD6_F',$,$,$,(#70),#71);
#73=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#74=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#75=IFCWALL('0EkiHYiyjLpQNvH88aN_jG',$,$,$,$,$,$,$,$);
#76=IFCPROPERTYSET('37dCRfl7zH8u_UMgpfwkN4',$,'Foo_Bar',$,(#78,#79));
#77=IFCRELDEFINESBYPROPERTIES('38ScSfV8vIxvdFIY_OpbuR',$,$,$,(#75),#76);
#78=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#79=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('z'),$);
#80=IFCWALL('1alyMlGcrTH8qJBDFp9$Tn',$,$,$,$,$,$,$,$);
#81=IFCPROPERTYSET('2MfOkfqWfQSOo03vpufA6M',$,'Foo_Bar',$,(#83));
#82=IFCRELDEFINESBYPROPERTIES('17I6O4APPJbvyM6hy7zVLx',$,$,$,(#80),#81);
#83=IFCPROPERTYSINGLEVALUE('Foo',$,IFCTIMEMEASURE(2.),$);
#84=IFCWALL('0JHV6tGG1P89eeyxS772p$',$,$,$,$,$,$,$,$);
#85=IFCPROPERTYSET('0rqo2fFffSSuedJDfGh4p6',$,'Foo_Bar',$,(#87));
#86=IFCRELDEFINESBYPROPERTIES('0182XiYTzPduj0OGf91UOP',$,$,$,(#84),#85);
#87=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLENGTHMEASURE(2000.),$);
#88=IFCWALL('0XC1gi9RbQ$hGVyGWYMpnf',$,$,$,$,$,$,$,$); /* Testcase */
#89=IFCWALLTYPE('3GkiL3W6nM5eq1Rpc$icnc',$,$,$,$,(#91),$,$,$,.ELEMENTEDWALL.);
#90=IFCRELDEFINESBYTYPE('1$j0fHR5zI69lbz3XMLUVv',$,$,$,(#88),#89);
#91=IFCPROPERTYSET('2byQV7c1fJ6u4FomZ26bXX',$,'Foo_Bar',$,(#92));
#92=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-properties_can_be_inherited_from_the_type_1_2.ids) - [Sample IFC: 88](testcases/property/pass-properties_can_be_inherited_from_the_type_1_2.ifc)

## [PASS] Properties can be inherited from the type 2/2

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$);
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
#57=IFCWALL('06dBUGnorHr9WTofAidJHU',$,$,$,$,$,$,$,$);
#58=IFCELEMENTQUANTITY('3AX9vL9EnKsugqFO9zvGI8',$,'Foo_Bar',$,$,(#60));
#59=IFCRELDEFINESBYPROPERTIES('1f2z3t2m1M_PU1dzQHWaTY',$,$,$,(#57),#58);
#60=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#61),'FurThickness',$,$);
#61=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
#62=IFCWALL('0L0eAFgLXNmQCI$MkB3EKH',$,$,$,$,$,$,$,$);
#63=IFCPROPERTYSET('1HUXyD$vHLSuOw2lJ4CGK1',$,'Foo_Bar',$,(#65));
#64=IFCRELDEFINESBYPROPERTIES('35ZNU4RLPSjQvdV$voX4wj',$,$,$,(#62),#63);
#65=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#66=IFCPROPERTYSET('3TYjDOTovQt9yfYD96b89K',$,'Foo_Baz',$,(#68,#69));
#67=IFCRELDEFINESBYPROPERTIES('3mG97g3IDRxQTRsJyocvys',$,$,$,(#62),#66);
#68=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#69=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#70=IFCWALL('3hmvEohnXRTBQcz0B8Km$H',$,$,$,$,$,$,$,$);
#71=IFCPROPERTYSET('20M738grnLZgxtK88cIOjo',$,'Foo_Bar',$,(#73,#74));
#72=IFCRELDEFINESBYPROPERTIES('3YEncJrUrHZOy4ZAVgD6_F',$,$,$,(#70),#71);
#73=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#74=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#75=IFCWALL('0EkiHYiyjLpQNvH88aN_jG',$,$,$,$,$,$,$,$);
#76=IFCPROPERTYSET('37dCRfl7zH8u_UMgpfwkN4',$,'Foo_Bar',$,(#78,#79));
#77=IFCRELDEFINESBYPROPERTIES('38ScSfV8vIxvdFIY_OpbuR',$,$,$,(#75),#76);
#78=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#79=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('z'),$);
#80=IFCWALL('1alyMlGcrTH8qJBDFp9$Tn',$,$,$,$,$,$,$,$);
#81=IFCPROPERTYSET('2MfOkfqWfQSOo03vpufA6M',$,'Foo_Bar',$,(#83));
#82=IFCRELDEFINESBYPROPERTIES('17I6O4APPJbvyM6hy7zVLx',$,$,$,(#80),#81);
#83=IFCPROPERTYSINGLEVALUE('Foo',$,IFCTIMEMEASURE(2.),$);
#84=IFCWALL('0JHV6tGG1P89eeyxS772p$',$,$,$,$,$,$,$,$);
#85=IFCPROPERTYSET('0rqo2fFffSSuedJDfGh4p6',$,'Foo_Bar',$,(#87));
#86=IFCRELDEFINESBYPROPERTIES('0182XiYTzPduj0OGf91UOP',$,$,$,(#84),#85);
#87=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLENGTHMEASURE(2000.),$);
#88=IFCWALL('0XC1gi9RbQ$hGVyGWYMpnf',$,$,$,$,$,$,$,$);
#89=IFCWALLTYPE('3GkiL3W6nM5eq1Rpc$icnc',$,$,$,$,(#91),$,$,$,.ELEMENTEDWALL.); /* Testcase */
#90=IFCRELDEFINESBYTYPE('1$j0fHR5zI69lbz3XMLUVv',$,$,$,(#88),#89);
#91=IFCPROPERTYSET('2byQV7c1fJ6u4FomZ26bXX',$,'Foo_Bar',$,(#92));
#92=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-properties_can_be_inherited_from_the_type_2_2.ids) - [Sample IFC: 89](testcases/property/pass-properties_can_be_inherited_from_the_type_2_2.ifc)

## [PASS] Properties can be overriden by an occurrence 1/2

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$);
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
#57=IFCWALL('06dBUGnorHr9WTofAidJHU',$,$,$,$,$,$,$,$);
#58=IFCELEMENTQUANTITY('3AX9vL9EnKsugqFO9zvGI8',$,'Foo_Bar',$,$,(#60));
#59=IFCRELDEFINESBYPROPERTIES('1f2z3t2m1M_PU1dzQHWaTY',$,$,$,(#57),#58);
#60=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#61),'FurThickness',$,$);
#61=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
#62=IFCWALL('0L0eAFgLXNmQCI$MkB3EKH',$,$,$,$,$,$,$,$);
#63=IFCPROPERTYSET('1HUXyD$vHLSuOw2lJ4CGK1',$,'Foo_Bar',$,(#65));
#64=IFCRELDEFINESBYPROPERTIES('35ZNU4RLPSjQvdV$voX4wj',$,$,$,(#62),#63);
#65=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#66=IFCPROPERTYSET('3TYjDOTovQt9yfYD96b89K',$,'Foo_Baz',$,(#68,#69));
#67=IFCRELDEFINESBYPROPERTIES('3mG97g3IDRxQTRsJyocvys',$,$,$,(#62),#66);
#68=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#69=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#70=IFCWALL('3hmvEohnXRTBQcz0B8Km$H',$,$,$,$,$,$,$,$);
#71=IFCPROPERTYSET('20M738grnLZgxtK88cIOjo',$,'Foo_Bar',$,(#73,#74));
#72=IFCRELDEFINESBYPROPERTIES('3YEncJrUrHZOy4ZAVgD6_F',$,$,$,(#70),#71);
#73=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#74=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#75=IFCWALL('0EkiHYiyjLpQNvH88aN_jG',$,$,$,$,$,$,$,$);
#76=IFCPROPERTYSET('37dCRfl7zH8u_UMgpfwkN4',$,'Foo_Bar',$,(#78,#79));
#77=IFCRELDEFINESBYPROPERTIES('38ScSfV8vIxvdFIY_OpbuR',$,$,$,(#75),#76);
#78=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#79=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('z'),$);
#80=IFCWALL('1alyMlGcrTH8qJBDFp9$Tn',$,$,$,$,$,$,$,$);
#81=IFCPROPERTYSET('2MfOkfqWfQSOo03vpufA6M',$,'Foo_Bar',$,(#83));
#82=IFCRELDEFINESBYPROPERTIES('17I6O4APPJbvyM6hy7zVLx',$,$,$,(#80),#81);
#83=IFCPROPERTYSINGLEVALUE('Foo',$,IFCTIMEMEASURE(2.),$);
#84=IFCWALL('0JHV6tGG1P89eeyxS772p$',$,$,$,$,$,$,$,$);
#85=IFCPROPERTYSET('0rqo2fFffSSuedJDfGh4p6',$,'Foo_Bar',$,(#87));
#86=IFCRELDEFINESBYPROPERTIES('0182XiYTzPduj0OGf91UOP',$,$,$,(#84),#85);
#87=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLENGTHMEASURE(2000.),$);
#88=IFCWALL('0XC1gi9RbQ$hGVyGWYMpnf',$,$,$,$,$,$,$,$);
#89=IFCWALLTYPE('3GkiL3W6nM5eq1Rpc$icnc',$,$,$,$,(#91),$,$,$,.ELEMENTEDWALL.);
#90=IFCRELDEFINESBYTYPE('1$j0fHR5zI69lbz3XMLUVv',$,$,$,(#88),#89);
#91=IFCPROPERTYSET('2byQV7c1fJ6u4FomZ26bXX',$,'Foo_Bar',$,(#92));
#92=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#93=IFCWALL('3CmZ4jxQzPhQunusfOZ_UA',$,$,$,$,$,$,$,$); /* Testcase */
#94=IFCWALLTYPE('3pWmCHa4LGtgDwQb84jOaS',$,$,$,$,(#96),$,$,$,.ELEMENTEDWALL.);
#95=IFCRELDEFINESBYTYPE('2j22znggrQHuh8nCcX8DPd',$,$,$,(#93),#94);
#96=IFCPROPERTYSET('12lpkRl6XG$A1MvfzKM0R6',$,'Foo_Bar',$,(#97));
#97=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Baz'),$);
#98=IFCPROPERTYSET('3fNlq1rwHLxwtbQHnTay3m',$,'Foo_Bar',$,(#100));
#99=IFCRELDEFINESBYPROPERTIES('1JcWRfRZHScuu_rCZwWKKK',$,$,$,(#93),#98);
#100=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/pass-properties_can_be_overriden_by_an_occurrence_1_2.ids) - [Sample IFC: 93](testcases/property/pass-properties_can_be_overriden_by_an_occurrence_1_2.ifc)

## [FAIL] Properties can be overriden by an occurrence 2/2

~~~xml
<property measure="IfcLabel" minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('2nJrDaLQfJ1QPhdJR0o97J',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#4,#2,#5,#3));
#7=IFCWALL('21nBfU8VHIqvcR36t_P1iE',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('2nJrDaLQfJ1QPhdJR0o97J',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('16MocU_IDOF8_x3Iqllz0d',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#12=IFCWALL('1n81bO_6nGjgypJwWUVavJ',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('3b0AoFivPN6RDJO6UL_GfZ',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('1UJX0DW6PGVvNXUEmD0sBq',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#16=IFCWALL('2jG7cjHsrIUfgKVktNgbzi',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('1X7Mz0AZrMOPkukNM5XTEV',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3CEylLjX9L0huf3t4LJMIA',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#20=IFCWALL('2J464n_AnPNgUfYvzrChAh',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('3NmyAazpzLq8cIG7JPLlM9',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('3Wzl48UnnIp8YxtLF4v8ZP',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#24=IFCWALL('0RSL8wCT5PN9gJFcsABneg',$,$,$,$,$,$,$,$);
#25=IFCPROPERTYSET('21nBfU8VHIqvcR36t_P1iE',$,'Pset_WallCommon',$,(#28));
#26=IFCRELDEFINESBYPROPERTIES('3uvq$MvJ1G9Bh_81VP1e9A',$,$,$,(#24),#25);
#27=IFCPROPERTYENUMERATION('Status',(IFCLABEL('NEW'),IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH'),IFCLABEL('TEMPORARY'),IFCLABEL('OTHER'),IFCLABEL('NOTKNOWN'),IFCLABEL('UNSET')),$);
#28=IFCPROPERTYENUMERATEDVALUE('Status',$,(IFCLABEL('EXISTING'),IFCLABEL('DEMOLISH')),#27);
#29=IFCWALL('2de$MNI$LGLOjZiSngF_vG',$,$,$,$,$,$,$,$);
#30=IFCPROPERTYSET('2wP8lRhDTKrxIPJKeaifuL',$,'Foo_Bar',$,(#32));
#31=IFCRELDEFINESBYPROPERTIES('1KlbEiNjDIJAGwnYBZ2B87',$,$,$,(#29),#30);
#32=IFCPROPERTYLISTVALUE('Foo',$,(IFCLABEL('X'),IFCLABEL('Y')),$);
#33=IFCWALL('0YwTGeJUPSxgVHD3te0HY$',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2cohnZTsfUgQK$4UvlhCtt',$,'Foo_Bar',$,(#36));
#35=IFCRELDEFINESBYPROPERTIES('0SvF7iJ0nUFuDA0RAthkuL',$,$,$,(#33),#34);
#36=IFCPROPERTYBOUNDEDVALUE('Foo',$,IFCLENGTHMEASURE(5000.),IFCLENGTHMEASURE(1000.),$,IFCLENGTHMEASURE(3000.));
#37=IFCWALL('0twQuvOmHLbQhwOoFZW2Qc',$,$,$,$,$,$,$,$);
#38=IFCPROPERTYSET('3yZ83FbJHHSPECOji2VuR7',$,'Foo_Bar',$,(#40));
#39=IFCRELDEFINESBYPROPERTIES('1zuFxqs7jRvBmbYESXTcGe',$,$,$,(#37),#38);
#40=IFCPROPERTYTABLEVALUE('Foo',$,(IFCLABEL('X')),(IFCLENGTHMEASURE(1000.)),$,$,$,$);
#41=IFCWALL('2YMHNxvqnTN83GZjqpyc06',$,$,$,$,$,$,$,$);
#42=IFCPROPERTYSET('3SczWGZuLL1uRf7PIAKFBJ',$,'Foo_Bar',$,(#44));
#43=IFCRELDEFINESBYPROPERTIES('2v2P1sEjTK1wOz4wfq91dp',$,$,$,(#41),#42);
#44=IFCPROPERTYREFERENCEVALUE('Foo',$,$,$);
#45=IFCDOOR('1HV2ll_PnSeRPomLlFZvpy',$,$,$,$,$,$,$,$,$,$,$,$);
#46=IFCDOORPANELPROPERTIES('2FBMTX1wLHcOg6LMzNUxWn',$,'Foo_Bar',$,$,.SWINGING.,$,.LEFT.,$);
#47=IFCRELDEFINESBYPROPERTIES('0Us22dl9nHdemGlS9q2O6G',$,$,$,(#45),#46);
#48=IFCWALL('0YBEu$TofO0eQ4LV7OUw3P',$,$,$,$,$,$,$,$);
#49=IFCELEMENTQUANTITY('0tYmbdoxPSSA$f8738u3HL',$,'Foo_Bar',$,$,(#51));
#50=IFCRELDEFINESBYPROPERTIES('0SHzKrDWfGQPDn0gQCC5YA',$,$,$,(#48),#49);
#51=IFCQUANTITYLENGTH('Foo',$,$,42.,$);
#52=IFCWALL('37ldeWsDDPMRPoIDS8LeIC',$,$,$,$,$,$,$,$);
#53=IFCPROPERTYSET('2zXlywiHXNXuMwtJxIrOU8',$,'Foo_Bar',$,(#55));
#54=IFCRELDEFINESBYPROPERTIES('1t0fvzj9jISuzujVWXwkVz',$,$,$,(#52),#53);
#55=IFCCOMPLEXPROPERTY('Foo',$,'RabbitAgilityTraining',(#56));
#56=IFCPROPERTYSINGLEVALUE('Rabbits',$,IFCLABEL('Awesome'),$);
#57=IFCWALL('06dBUGnorHr9WTofAidJHU',$,$,$,$,$,$,$,$);
#58=IFCELEMENTQUANTITY('3AX9vL9EnKsugqFO9zvGI8',$,'Foo_Bar',$,$,(#60));
#59=IFCRELDEFINESBYPROPERTIES('1f2z3t2m1M_PU1dzQHWaTY',$,$,$,(#57),#58);
#60=IFCPHYSICALCOMPLEXQUANTITY('Foo',$,(#61),'FurThickness',$,$);
#61=IFCQUANTITYLENGTH('MyLength',$,$,42.,$);
#62=IFCWALL('0L0eAFgLXNmQCI$MkB3EKH',$,$,$,$,$,$,$,$);
#63=IFCPROPERTYSET('1HUXyD$vHLSuOw2lJ4CGK1',$,'Foo_Bar',$,(#65));
#64=IFCRELDEFINESBYPROPERTIES('35ZNU4RLPSjQvdV$voX4wj',$,$,$,(#62),#63);
#65=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#66=IFCPROPERTYSET('3TYjDOTovQt9yfYD96b89K',$,'Foo_Baz',$,(#68,#69));
#67=IFCRELDEFINESBYPROPERTIES('3mG97g3IDRxQTRsJyocvys',$,$,$,(#62),#66);
#68=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#69=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#70=IFCWALL('3hmvEohnXRTBQcz0B8Km$H',$,$,$,$,$,$,$,$);
#71=IFCPROPERTYSET('20M738grnLZgxtK88cIOjo',$,'Foo_Bar',$,(#73,#74));
#72=IFCRELDEFINESBYPROPERTIES('3YEncJrUrHZOy4ZAVgD6_F',$,$,$,(#70),#71);
#73=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#74=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#75=IFCWALL('0EkiHYiyjLpQNvH88aN_jG',$,$,$,$,$,$,$,$);
#76=IFCPROPERTYSET('37dCRfl7zH8u_UMgpfwkN4',$,'Foo_Bar',$,(#78,#79));
#77=IFCRELDEFINESBYPROPERTIES('38ScSfV8vIxvdFIY_OpbuR',$,$,$,(#75),#76);
#78=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#79=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('z'),$);
#80=IFCWALL('1alyMlGcrTH8qJBDFp9$Tn',$,$,$,$,$,$,$,$);
#81=IFCPROPERTYSET('2MfOkfqWfQSOo03vpufA6M',$,'Foo_Bar',$,(#83));
#82=IFCRELDEFINESBYPROPERTIES('17I6O4APPJbvyM6hy7zVLx',$,$,$,(#80),#81);
#83=IFCPROPERTYSINGLEVALUE('Foo',$,IFCTIMEMEASURE(2.),$);
#84=IFCWALL('0JHV6tGG1P89eeyxS772p$',$,$,$,$,$,$,$,$);
#85=IFCPROPERTYSET('0rqo2fFffSSuedJDfGh4p6',$,'Foo_Bar',$,(#87));
#86=IFCRELDEFINESBYPROPERTIES('0182XiYTzPduj0OGf91UOP',$,$,$,(#84),#85);
#87=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLENGTHMEASURE(2000.),$);
#88=IFCWALL('0XC1gi9RbQ$hGVyGWYMpnf',$,$,$,$,$,$,$,$);
#89=IFCWALLTYPE('3GkiL3W6nM5eq1Rpc$icnc',$,$,$,$,(#91),$,$,$,.ELEMENTEDWALL.);
#90=IFCRELDEFINESBYTYPE('1$j0fHR5zI69lbz3XMLUVv',$,$,$,(#88),#89);
#91=IFCPROPERTYSET('2byQV7c1fJ6u4FomZ26bXX',$,'Foo_Bar',$,(#92));
#92=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#93=IFCWALL('3CmZ4jxQzPhQunusfOZ_UA',$,$,$,$,$,$,$,$);
#94=IFCWALLTYPE('3pWmCHa4LGtgDwQb84jOaS',$,$,$,$,(#96),$,$,$,.ELEMENTEDWALL.); /* Testcase */
#95=IFCRELDEFINESBYTYPE('2j22znggrQHuh8nCcX8DPd',$,$,$,(#93),#94);
#96=IFCPROPERTYSET('12lpkRl6XG$A1MvfzKM0R6',$,'Foo_Bar',$,(#97));
#97=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Baz'),$);
#98=IFCPROPERTYSET('3fNlq1rwHLxwtbQHnTay3m',$,'Foo_Bar',$,(#100));
#99=IFCRELDEFINESBYPROPERTIES('1JcWRfRZHScuu_rCZwWKKK',$,$,$,(#93),#98);
#100=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/property/fail-properties_can_be_overriden_by_an_occurrence_2_2.ids) - [Sample IFC: 94](testcases/property/fail-properties_can_be_overriden_by_an_occurrence_2_2.ifc)

