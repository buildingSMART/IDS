# Property testcases

These testcases are designed to help describe behaviour in edge cases and ambiguities. All valid IDS implementations must demonstrate identical behaviour to these test cases.

## [FAIL] Elements with no properties always fail

~~~xml
<property minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$); /* Testcase */
~~~

[Sample IDS](testcases/fail-elements_with_no_properties_always_fail.ids) - [Sample IFC: 7](testcases/fail-elements_with_no_properties_always_fail.ifc)

## [FAIL] Elements with a matching pset but no property also fail

~~~xml
<property minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
~~~

[Sample IDS](testcases/fail-elements_with_a_matching_pset_but_no_property_also_fail.ids) - [Sample IFC: 7](testcases/fail-elements_with_a_matching_pset_but_no_property_also_fail.ifc)

## [FAIL] Properties with a null value fail

~~~xml
<property minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
~~~

[Sample IDS](testcases/fail-properties_with_a_null_value_fail.ids) - [Sample IFC: 7](testcases/fail-properties_with_a_null_value_fail.ifc)

## [PASS] A name check will match any property with any string value

~~~xml
<property minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/pass-a_name_check_will_match_any_property_with_any_string_value.ids) - [Sample IFC: 7](testcases/pass-a_name_check_will_match_any_property_with_any_string_value.ifc)

## [FAIL] An empty string is considered falsey and will not pass

~~~xml
<property minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL(''),$);
~~~

[Sample IDS](testcases/fail-an_empty_string_is_considered_falsey_and_will_not_pass.ids) - [Sample IFC: 7](testcases/fail-an_empty_string_is_considered_falsey_and_will_not_pass.ifc)

## [FAIL] A logical unknown is considered falsey and will not pass

~~~xml
<property minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLOGICAL(.U.),$);
~~~

[Sample IDS](testcases/fail-a_logical_unknown_is_considered_falsey_and_will_not_pass.ids) - [Sample IFC: 7](testcases/fail-a_logical_unknown_is_considered_falsey_and_will_not_pass.ifc)

## [PASS] A zero duration will pass

~~~xml
<property minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P0D'),$);
~~~

[Sample IDS](testcases/pass-a_zero_duration_will_pass.ids) - [Sample IFC: 7](testcases/pass-a_zero_duration_will_pass.ifc)

## [PASS] A property set to true will pass a name check

~~~xml
<property minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.T.),$);
~~~

[Sample IDS](testcases/pass-a_property_set_to_true_will_pass_a_name_check.ids) - [Sample IFC: 7](testcases/pass-a_property_set_to_true_will_pass_a_name_check.ifc)

## [PASS] A property set to false is still considered a value and will pass a name check

~~~xml
<property minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$); /* Testcase */
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
~~~

[Sample IDS](testcases/pass-a_property_set_to_false_is_still_considered_a_value_and_will_pass_a_name_check.ids) - [Sample IFC: 7](testcases/pass-a_property_set_to_false_is_still_considered_a_value_and_will_pass_a_name_check.ifc)

## [PASS] Specifying a value performs a case-sensitive match 1/2

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$); /* Testcase */
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/pass-specifying_a_value_performs_a_case_sensitive_match_1_2.ids) - [Sample IFC: 12](testcases/pass-specifying_a_value_performs_a_case_sensitive_match_1_2.ifc)

## [FAIL] Specifying a value performs a case-sensitive match 2/2

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$); /* Testcase */
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('bar'),$);
~~~

[Sample IDS](testcases/fail-specifying_a_value_performs_a_case_sensitive_match_2_2.ids) - [Sample IFC: 12](testcases/fail-specifying_a_value_performs_a_case_sensitive_match_2_2.ifc)

## [FAIL] Specifying a value fails against different values

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$); /* Testcase */
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Baz'),$);
~~~

[Sample IDS](testcases/fail-specifying_a_value_fails_against_different_values.ids) - [Sample IFC: 12](testcases/fail-specifying_a_value_fails_against_different_values.ifc)

## [PASS] Non-ascii characters are treated without encoding

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$); /* Testcase */
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('\X2\266B\X0\'),$);
~~~

[Sample IDS](testcases/pass-non_ascii_characters_are_treated_without_encoding.ids) - [Sample IFC: 12](testcases/pass-non_ascii_characters_are_treated_without_encoding.ifc)

## [FAIL] IDS does not handle string truncation such as for identifiers

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$); /* Testcase */
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
~~~

[Sample IDS](testcases/fail-ids_does_not_handle_string_truncation_such_as_for_identifiers.ids) - [Sample IFC: 12](testcases/fail-ids_does_not_handle_string_truncation_such_as_for_identifiers.ifc)

## [PASS] A number specified as a string is treated as a string

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('1'),$);
~~~

[Sample IDS](testcases/pass-a_number_specified_as_a_string_is_treated_as_a_string.ids) - [Sample IFC: 16](testcases/pass-a_number_specified_as_a_string_is_treated_as_a_string.ifc)

## [PASS] Integer values are checked using type casting 1/4

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCINTEGER(42),$);
~~~

[Sample IDS](testcases/pass-integer_values_are_checked_using_type_casting_1_4.ids) - [Sample IFC: 16](testcases/pass-integer_values_are_checked_using_type_casting_1_4.ifc)

## [PASS] Integer values are checked using type casting 2/4

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCINTEGER(42),$);
~~~

[Sample IDS](testcases/pass-integer_values_are_checked_using_type_casting_2_4.ids) - [Sample IFC: 16](testcases/pass-integer_values_are_checked_using_type_casting_2_4.ifc)

## [PASS] Integer values are checked using type casting 3/4

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCINTEGER(42),$);
~~~

[Sample IDS](testcases/pass-integer_values_are_checked_using_type_casting_3_4.ids) - [Sample IFC: 16](testcases/pass-integer_values_are_checked_using_type_casting_3_4.ifc)

## [FAIL] Integer values are checked using type casting 4/4

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCINTEGER(42),$);
~~~

[Sample IDS](testcases/fail-integer_values_are_checked_using_type_casting_4_4.ids) - [Sample IFC: 16](testcases/fail-integer_values_are_checked_using_type_casting_4_4.ifc)

## [PASS] Real values are checked using type casting 1/3

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(42.),$);
~~~

[Sample IDS](testcases/pass-real_values_are_checked_using_type_casting_1_3.ids) - [Sample IFC: 16](testcases/pass-real_values_are_checked_using_type_casting_1_3.ifc)

## [PASS] Real values are checked using type casting 2/3

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(42.),$);
~~~

[Sample IDS](testcases/pass-real_values_are_checked_using_type_casting_2_3.ids) - [Sample IFC: 16](testcases/pass-real_values_are_checked_using_type_casting_2_3.ifc)

## [PASS] Real values are checked using type casting 3/3

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(42.3),$);
~~~

[Sample IDS](testcases/pass-real_values_are_checked_using_type_casting_3_3.ids) - [Sample IFC: 16](testcases/pass-real_values_are_checked_using_type_casting_3_3.ifc)

## [FAIL] Only specifically formatted numbers are allowed 1/4

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(42.3),$);
~~~

[Sample IDS](testcases/fail-only_specifically_formatted_numbers_are_allowed_1_4.ids) - [Sample IFC: 16](testcases/fail-only_specifically_formatted_numbers_are_allowed_1_4.ifc)

## [FAIL] Only specifically formatted numbers are allowed 2/4

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(1234.5),$);
~~~

[Sample IDS](testcases/fail-only_specifically_formatted_numbers_are_allowed_2_4.ids) - [Sample IFC: 16](testcases/fail-only_specifically_formatted_numbers_are_allowed_2_4.ifc)

## [PASS] Only specifically formatted numbers are allowed 3/4

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(1234.5),$);
~~~

[Sample IDS](testcases/pass-only_specifically_formatted_numbers_are_allowed_3_4.ids) - [Sample IFC: 16](testcases/pass-only_specifically_formatted_numbers_are_allowed_3_4.ifc)

## [PASS] Only specifically formatted numbers are allowed 4/4

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(1234.5),$);
~~~

[Sample IDS](testcases/pass-only_specifically_formatted_numbers_are_allowed_4_4.ids) - [Sample IFC: 16](testcases/pass-only_specifically_formatted_numbers_are_allowed_4_4.ifc)

## [PASS] Floating point numbers are compared with a 1e-6 tolerance 1/4

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(42.000042),$);
~~~

[Sample IDS](testcases/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_1_4.ids) - [Sample IFC: 16](testcases/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_1_4.ifc)

## [PASS] Floating point numbers are compared with a 1e-6 tolerance 2/4

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(41.999958),$);
~~~

[Sample IDS](testcases/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_2_4.ids) - [Sample IFC: 16](testcases/pass-floating_point_numbers_are_compared_with_a_1e_6_tolerance_2_4.ifc)

## [FAIL] Floating point numbers are compared with a 1e-6 tolerance 3/4

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(42.000084),$);
~~~

[Sample IDS](testcases/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_3_4.ids) - [Sample IFC: 16](testcases/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_3_4.ifc)

## [FAIL] Floating point numbers are compared with a 1e-6 tolerance 4/4

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCREAL(41.999916),$);
~~~

[Sample IDS](testcases/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_4_4.ids) - [Sample IFC: 16](testcases/fail-floating_point_numbers_are_compared_with_a_1e_6_tolerance_4_4.ifc)

## [FAIL] Booleans must be specified as uppercase strings 1/3

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
~~~

[Sample IDS](testcases/fail-booleans_must_be_specified_as_uppercase_strings_1_3.ids) - [Sample IFC: 16](testcases/fail-booleans_must_be_specified_as_uppercase_strings_1_3.ifc)

## [PASS] Booleans must be specified as uppercase strings 2/3

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
~~~

[Sample IDS](testcases/pass-booleans_must_be_specified_as_uppercase_strings_2_3.ids) - [Sample IFC: 16](testcases/pass-booleans_must_be_specified_as_uppercase_strings_2_3.ifc)

## [FAIL] Booleans must be specified as uppercase strings 3/3

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
~~~

[Sample IDS](testcases/fail-booleans_must_be_specified_as_uppercase_strings_3_3.ids) - [Sample IFC: 16](testcases/fail-booleans_must_be_specified_as_uppercase_strings_3_3.ifc)

## [PASS] Dates are treated as strings 1/2

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDATE('2022-01-01'),$);
~~~

[Sample IDS](testcases/pass-dates_are_treated_as_strings_1_2.ids) - [Sample IFC: 16](testcases/pass-dates_are_treated_as_strings_1_2.ifc)

## [FAIL] Dates are treated as strings 2/2

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDATE('2022-01-01+00:00'),$);
~~~

[Sample IDS](testcases/fail-dates_are_treated_as_strings_2_2.ids) - [Sample IFC: 16](testcases/fail-dates_are_treated_as_strings_2_2.ifc)

## [PASS] Durations are treated as strings 1/2

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('PT16H'),$);
~~~

[Sample IDS](testcases/pass-durations_are_treated_as_strings_1_2.ids) - [Sample IFC: 16](testcases/pass-durations_are_treated_as_strings_1_2.ifc)

## [FAIL] Durations are treated as strings 1/2

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$); /* Testcase */
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
~~~

[Sample IDS](testcases/fail-durations_are_treated_as_strings_1_2.ids) - [Sample IFC: 16](testcases/fail-durations_are_treated_as_strings_1_2.ifc)

## [PASS] All matching property sets must satisfy requirements 1/3

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#20=IFCWALL('18IoQzCPfFqxhHNfS3eHFd',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('1F_evSXS99iRKa$hGUPQy$',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('0zyZ0$bmn7Af7ujZshLMLb',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/pass-all_matching_property_sets_must_satisfy_requirements_1_3.ids) - [Sample IFC: 20](testcases/pass-all_matching_property_sets_must_satisfy_requirements_1_3.ifc)

## [FAIL] All matching property sets must satisfy requirements 2/3

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#20=IFCWALL('18IoQzCPfFqxhHNfS3eHFd',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('1F_evSXS99iRKa$hGUPQy$',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('0zyZ0$bmn7Af7ujZshLMLb',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#24=IFCPROPERTYSET('0s8EpNT$97pxuRRcXV5VKb',$,'Foo_Baz',$,(#26));
#25=IFCRELDEFINESBYPROPERTIES('27UuKxq2H7AxHRiiMU5WML',$,$,$,(#20),#24);
#26=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
~~~

[Sample IDS](testcases/fail-all_matching_property_sets_must_satisfy_requirements_2_3.ids) - [Sample IFC: 20](testcases/fail-all_matching_property_sets_must_satisfy_requirements_2_3.ifc)

## [PASS] All matching property sets must satisfy requirements 3/3

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#20=IFCWALL('18IoQzCPfFqxhHNfS3eHFd',$,$,$,$,$,$,$,$); /* Testcase */
#21=IFCPROPERTYSET('1F_evSXS99iRKa$hGUPQy$',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('0zyZ0$bmn7Af7ujZshLMLb',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#24=IFCPROPERTYSET('0s8EpNT$97pxuRRcXV5VKb',$,'Foo_Baz',$,(#26,#27));
#25=IFCRELDEFINESBYPROPERTIES('27UuKxq2H7AxHRiiMU5WML',$,$,$,(#20),#24);
#26=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#27=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/pass-all_matching_property_sets_must_satisfy_requirements_3_3.ids) - [Sample IFC: 20](testcases/pass-all_matching_property_sets_must_satisfy_requirements_3_3.ifc)

## [PASS] All matching properties must satisfy requirements 1/3

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#20=IFCWALL('18IoQzCPfFqxhHNfS3eHFd',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('1F_evSXS99iRKa$hGUPQy$',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('0zyZ0$bmn7Af7ujZshLMLb',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#24=IFCPROPERTYSET('0s8EpNT$97pxuRRcXV5VKb',$,'Foo_Baz',$,(#26,#27));
#25=IFCRELDEFINESBYPROPERTIES('27UuKxq2H7AxHRiiMU5WML',$,$,$,(#20),#24);
#26=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#27=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#28=IFCWALL('1O_Pve4I54z83jk9EPXg_q',$,$,$,$,$,$,$,$); /* Testcase */
#29=IFCPROPERTYSET('1I9KszTPzBbfJFylsO2yZT',$,'Foo_Bar',$,(#31));
#30=IFCRELDEFINESBYPROPERTIES('0GfGT06wv8HAISFMMrpZpk',$,$,$,(#28),#29);
#31=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
~~~

[Sample IDS](testcases/pass-all_matching_properties_must_satisfy_requirements_1_3.ids) - [Sample IFC: 28](testcases/pass-all_matching_properties_must_satisfy_requirements_1_3.ifc)

## [PASS] All matching properties must satisfy requirements 2/3

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#20=IFCWALL('18IoQzCPfFqxhHNfS3eHFd',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('1F_evSXS99iRKa$hGUPQy$',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('0zyZ0$bmn7Af7ujZshLMLb',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#24=IFCPROPERTYSET('0s8EpNT$97pxuRRcXV5VKb',$,'Foo_Baz',$,(#26,#27));
#25=IFCRELDEFINESBYPROPERTIES('27UuKxq2H7AxHRiiMU5WML',$,$,$,(#20),#24);
#26=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#27=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#28=IFCWALL('1O_Pve4I54z83jk9EPXg_q',$,$,$,$,$,$,$,$); /* Testcase */
#29=IFCPROPERTYSET('1I9KszTPzBbfJFylsO2yZT',$,'Foo_Bar',$,(#31,#32));
#30=IFCRELDEFINESBYPROPERTIES('0GfGT06wv8HAISFMMrpZpk',$,$,$,(#28),#29);
#31=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#32=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('x'),$);
~~~

[Sample IDS](testcases/pass-all_matching_properties_must_satisfy_requirements_2_3.ids) - [Sample IFC: 28](testcases/pass-all_matching_properties_must_satisfy_requirements_2_3.ifc)

## [FAIL] All matching properties must satisfy requirements 3/3

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#20=IFCWALL('18IoQzCPfFqxhHNfS3eHFd',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('1F_evSXS99iRKa$hGUPQy$',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('0zyZ0$bmn7Af7ujZshLMLb',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#24=IFCPROPERTYSET('0s8EpNT$97pxuRRcXV5VKb',$,'Foo_Baz',$,(#26,#27));
#25=IFCRELDEFINESBYPROPERTIES('27UuKxq2H7AxHRiiMU5WML',$,$,$,(#20),#24);
#26=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#27=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#28=IFCWALL('1O_Pve4I54z83jk9EPXg_q',$,$,$,$,$,$,$,$); /* Testcase */
#29=IFCPROPERTYSET('1I9KszTPzBbfJFylsO2yZT',$,'Foo_Bar',$,(#31,#32));
#30=IFCRELDEFINESBYPROPERTIES('0GfGT06wv8HAISFMMrpZpk',$,$,$,(#28),#29);
#31=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#32=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
~~~

[Sample IDS](testcases/fail-all_matching_properties_must_satisfy_requirements_3_3.ids) - [Sample IFC: 28](testcases/fail-all_matching_properties_must_satisfy_requirements_3_3.ifc)

## [PASS] If multiple properties are matched, all values must satisfy requirements 1/2

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#20=IFCWALL('18IoQzCPfFqxhHNfS3eHFd',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('1F_evSXS99iRKa$hGUPQy$',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('0zyZ0$bmn7Af7ujZshLMLb',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#24=IFCPROPERTYSET('0s8EpNT$97pxuRRcXV5VKb',$,'Foo_Baz',$,(#26,#27));
#25=IFCRELDEFINESBYPROPERTIES('27UuKxq2H7AxHRiiMU5WML',$,$,$,(#20),#24);
#26=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#27=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#28=IFCWALL('1O_Pve4I54z83jk9EPXg_q',$,$,$,$,$,$,$,$);
#29=IFCPROPERTYSET('1I9KszTPzBbfJFylsO2yZT',$,'Foo_Bar',$,(#31,#32));
#30=IFCRELDEFINESBYPROPERTIES('0GfGT06wv8HAISFMMrpZpk',$,$,$,(#28),#29);
#31=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#32=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#33=IFCWALL('3Uy2pY7ALBTwCdICK_P4$N',$,$,$,$,$,$,$,$); /* Testcase */
#34=IFCPROPERTYSET('2oZai9eATBqxJ5tVkuOTuY',$,'Foo_Bar',$,(#36,#37));
#35=IFCRELDEFINESBYPROPERTIES('23Gf7Bqm95uREb52AOjFdb',$,$,$,(#33),#34);
#36=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#37=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
~~~

[Sample IDS](testcases/pass-if_multiple_properties_are_matched__all_values_must_satisfy_requirements_1_2.ids) - [Sample IFC: 33](testcases/pass-if_multiple_properties_are_matched__all_values_must_satisfy_requirements_1_2.ifc)

## [FAIL] If multiple properties are matched, all values must satisfy requirements 2/2

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#20=IFCWALL('18IoQzCPfFqxhHNfS3eHFd',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('1F_evSXS99iRKa$hGUPQy$',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('0zyZ0$bmn7Af7ujZshLMLb',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#24=IFCPROPERTYSET('0s8EpNT$97pxuRRcXV5VKb',$,'Foo_Baz',$,(#26,#27));
#25=IFCRELDEFINESBYPROPERTIES('27UuKxq2H7AxHRiiMU5WML',$,$,$,(#20),#24);
#26=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#27=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#28=IFCWALL('1O_Pve4I54z83jk9EPXg_q',$,$,$,$,$,$,$,$);
#29=IFCPROPERTYSET('1I9KszTPzBbfJFylsO2yZT',$,'Foo_Bar',$,(#31,#32));
#30=IFCRELDEFINESBYPROPERTIES('0GfGT06wv8HAISFMMrpZpk',$,$,$,(#28),#29);
#31=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#32=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#33=IFCWALL('3Uy2pY7ALBTwCdICK_P4$N',$,$,$,$,$,$,$,$); /* Testcase */
#34=IFCPROPERTYSET('2oZai9eATBqxJ5tVkuOTuY',$,'Foo_Bar',$,(#36,#37));
#35=IFCRELDEFINESBYPROPERTIES('23Gf7Bqm95uREb52AOjFdb',$,$,$,(#33),#34);
#36=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#37=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('z'),$);
~~~

[Sample IDS](testcases/fail-if_multiple_properties_are_matched__all_values_must_satisfy_requirements_2_2.ids) - [Sample IFC: 33](testcases/fail-if_multiple_properties_are_matched__all_values_must_satisfy_requirements_2_2.ifc)

## [FAIL] Measure may be used to specify an IFC data type 1/2

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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#20=IFCWALL('18IoQzCPfFqxhHNfS3eHFd',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('1F_evSXS99iRKa$hGUPQy$',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('0zyZ0$bmn7Af7ujZshLMLb',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#24=IFCPROPERTYSET('0s8EpNT$97pxuRRcXV5VKb',$,'Foo_Baz',$,(#26,#27));
#25=IFCRELDEFINESBYPROPERTIES('27UuKxq2H7AxHRiiMU5WML',$,$,$,(#20),#24);
#26=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#27=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#28=IFCWALL('1O_Pve4I54z83jk9EPXg_q',$,$,$,$,$,$,$,$);
#29=IFCPROPERTYSET('1I9KszTPzBbfJFylsO2yZT',$,'Foo_Bar',$,(#31,#32));
#30=IFCRELDEFINESBYPROPERTIES('0GfGT06wv8HAISFMMrpZpk',$,$,$,(#28),#29);
#31=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#32=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#33=IFCWALL('3Uy2pY7ALBTwCdICK_P4$N',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2oZai9eATBqxJ5tVkuOTuY',$,'Foo_Bar',$,(#36,#37));
#35=IFCRELDEFINESBYPROPERTIES('23Gf7Bqm95uREb52AOjFdb',$,$,$,(#33),#34);
#36=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#37=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('z'),$);
#38=IFCWALL('32KlQ7klX9cuTpvX17_zzf',$,$,$,$,$,$,$,$); /* Testcase */
#39=IFCPROPERTYSET('0rvcfWIgT4fgCX1B4RtoGt',$,'Foo_Bar',$,(#41));
#40=IFCRELDEFINESBYPROPERTIES('03Y86B3Bf6GfqMksFSTVLS',$,$,$,(#38),#39);
#41=IFCPROPERTYSINGLEVALUE('Foo',$,IFCMASSMEASURE(2.),$);
~~~

[Sample IDS](testcases/fail-measure_may_be_used_to_specify_an_ifc_data_type_1_2.ids) - [Sample IFC: 38](testcases/fail-measure_may_be_used_to_specify_an_ifc_data_type_1_2.ifc)

## [PASS] Measure may be used to specify an IFC data type 2/2

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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#20=IFCWALL('18IoQzCPfFqxhHNfS3eHFd',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('1F_evSXS99iRKa$hGUPQy$',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('0zyZ0$bmn7Af7ujZshLMLb',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#24=IFCPROPERTYSET('0s8EpNT$97pxuRRcXV5VKb',$,'Foo_Baz',$,(#26,#27));
#25=IFCRELDEFINESBYPROPERTIES('27UuKxq2H7AxHRiiMU5WML',$,$,$,(#20),#24);
#26=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#27=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#28=IFCWALL('1O_Pve4I54z83jk9EPXg_q',$,$,$,$,$,$,$,$);
#29=IFCPROPERTYSET('1I9KszTPzBbfJFylsO2yZT',$,'Foo_Bar',$,(#31,#32));
#30=IFCRELDEFINESBYPROPERTIES('0GfGT06wv8HAISFMMrpZpk',$,$,$,(#28),#29);
#31=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#32=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#33=IFCWALL('3Uy2pY7ALBTwCdICK_P4$N',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2oZai9eATBqxJ5tVkuOTuY',$,'Foo_Bar',$,(#36,#37));
#35=IFCRELDEFINESBYPROPERTIES('23Gf7Bqm95uREb52AOjFdb',$,$,$,(#33),#34);
#36=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#37=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('z'),$);
#38=IFCWALL('32KlQ7klX9cuTpvX17_zzf',$,$,$,$,$,$,$,$); /* Testcase */
#39=IFCPROPERTYSET('0rvcfWIgT4fgCX1B4RtoGt',$,'Foo_Bar',$,(#41));
#40=IFCRELDEFINESBYPROPERTIES('03Y86B3Bf6GfqMksFSTVLS',$,$,$,(#38),#39);
#41=IFCPROPERTYSINGLEVALUE('Foo',$,IFCTIMEMEASURE(2.),$);
~~~

[Sample IDS](testcases/pass-measure_may_be_used_to_specify_an_ifc_data_type_2_2.ids) - [Sample IFC: 38](testcases/pass-measure_may_be_used_to_specify_an_ifc_data_type_2_2.ifc)

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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#20=IFCWALL('18IoQzCPfFqxhHNfS3eHFd',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('1F_evSXS99iRKa$hGUPQy$',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('0zyZ0$bmn7Af7ujZshLMLb',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#24=IFCPROPERTYSET('0s8EpNT$97pxuRRcXV5VKb',$,'Foo_Baz',$,(#26,#27));
#25=IFCRELDEFINESBYPROPERTIES('27UuKxq2H7AxHRiiMU5WML',$,$,$,(#20),#24);
#26=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#27=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#28=IFCWALL('1O_Pve4I54z83jk9EPXg_q',$,$,$,$,$,$,$,$);
#29=IFCPROPERTYSET('1I9KszTPzBbfJFylsO2yZT',$,'Foo_Bar',$,(#31,#32));
#30=IFCRELDEFINESBYPROPERTIES('0GfGT06wv8HAISFMMrpZpk',$,$,$,(#28),#29);
#31=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#32=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#33=IFCWALL('3Uy2pY7ALBTwCdICK_P4$N',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2oZai9eATBqxJ5tVkuOTuY',$,'Foo_Bar',$,(#36,#37));
#35=IFCRELDEFINESBYPROPERTIES('23Gf7Bqm95uREb52AOjFdb',$,$,$,(#33),#34);
#36=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#37=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('z'),$);
#38=IFCWALL('32KlQ7klX9cuTpvX17_zzf',$,$,$,$,$,$,$,$);
#39=IFCPROPERTYSET('0rvcfWIgT4fgCX1B4RtoGt',$,'Foo_Bar',$,(#41));
#40=IFCRELDEFINESBYPROPERTIES('03Y86B3Bf6GfqMksFSTVLS',$,$,$,(#38),#39);
#41=IFCPROPERTYSINGLEVALUE('Foo',$,IFCTIMEMEASURE(2.),$);
#42=IFCWALL('3$KYIGgsH9Vv$4TiBTeTZt',$,$,$,$,$,$,$,$); /* Testcase */
#43=IFCPROPERTYSET('0CeS9lcanBbu5bqfFg8ZE8',$,'Foo_Bar',$,(#45));
#44=IFCRELDEFINESBYPROPERTIES('2_n1GE3mfFxRFWpHp18LJc',$,$,$,(#42),#43);
#45=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLENGTHMEASURE(2.),$);
~~~

[Sample IDS](testcases/fail-unit_conversions_shall_take_place_to_ids_nominated_standard_units_1_2.ids) - [Sample IFC: 42](testcases/fail-unit_conversions_shall_take_place_to_ids_nominated_standard_units_1_2.ifc)

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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#20=IFCWALL('18IoQzCPfFqxhHNfS3eHFd',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('1F_evSXS99iRKa$hGUPQy$',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('0zyZ0$bmn7Af7ujZshLMLb',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#24=IFCPROPERTYSET('0s8EpNT$97pxuRRcXV5VKb',$,'Foo_Baz',$,(#26,#27));
#25=IFCRELDEFINESBYPROPERTIES('27UuKxq2H7AxHRiiMU5WML',$,$,$,(#20),#24);
#26=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#27=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#28=IFCWALL('1O_Pve4I54z83jk9EPXg_q',$,$,$,$,$,$,$,$);
#29=IFCPROPERTYSET('1I9KszTPzBbfJFylsO2yZT',$,'Foo_Bar',$,(#31,#32));
#30=IFCRELDEFINESBYPROPERTIES('0GfGT06wv8HAISFMMrpZpk',$,$,$,(#28),#29);
#31=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#32=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#33=IFCWALL('3Uy2pY7ALBTwCdICK_P4$N',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2oZai9eATBqxJ5tVkuOTuY',$,'Foo_Bar',$,(#36,#37));
#35=IFCRELDEFINESBYPROPERTIES('23Gf7Bqm95uREb52AOjFdb',$,$,$,(#33),#34);
#36=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#37=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('z'),$);
#38=IFCWALL('32KlQ7klX9cuTpvX17_zzf',$,$,$,$,$,$,$,$);
#39=IFCPROPERTYSET('0rvcfWIgT4fgCX1B4RtoGt',$,'Foo_Bar',$,(#41));
#40=IFCRELDEFINESBYPROPERTIES('03Y86B3Bf6GfqMksFSTVLS',$,$,$,(#38),#39);
#41=IFCPROPERTYSINGLEVALUE('Foo',$,IFCTIMEMEASURE(2.),$);
#42=IFCWALL('3$KYIGgsH9Vv$4TiBTeTZt',$,$,$,$,$,$,$,$); /* Testcase */
#43=IFCPROPERTYSET('0CeS9lcanBbu5bqfFg8ZE8',$,'Foo_Bar',$,(#45));
#44=IFCRELDEFINESBYPROPERTIES('2_n1GE3mfFxRFWpHp18LJc',$,$,$,(#42),#43);
#45=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLENGTHMEASURE(2000.),$);
~~~

[Sample IDS](testcases/pass-unit_conversions_shall_take_place_to_ids_nominated_standard_units_2_2.ids) - [Sample IFC: 42](testcases/pass-unit_conversions_shall_take_place_to_ids_nominated_standard_units_2_2.ifc)

## [PASS] Properties can be inherited from the type 1/2

~~~xml
<property minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#20=IFCWALL('18IoQzCPfFqxhHNfS3eHFd',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('1F_evSXS99iRKa$hGUPQy$',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('0zyZ0$bmn7Af7ujZshLMLb',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#24=IFCPROPERTYSET('0s8EpNT$97pxuRRcXV5VKb',$,'Foo_Baz',$,(#26,#27));
#25=IFCRELDEFINESBYPROPERTIES('27UuKxq2H7AxHRiiMU5WML',$,$,$,(#20),#24);
#26=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#27=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#28=IFCWALL('1O_Pve4I54z83jk9EPXg_q',$,$,$,$,$,$,$,$);
#29=IFCPROPERTYSET('1I9KszTPzBbfJFylsO2yZT',$,'Foo_Bar',$,(#31,#32));
#30=IFCRELDEFINESBYPROPERTIES('0GfGT06wv8HAISFMMrpZpk',$,$,$,(#28),#29);
#31=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#32=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#33=IFCWALL('3Uy2pY7ALBTwCdICK_P4$N',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2oZai9eATBqxJ5tVkuOTuY',$,'Foo_Bar',$,(#36,#37));
#35=IFCRELDEFINESBYPROPERTIES('23Gf7Bqm95uREb52AOjFdb',$,$,$,(#33),#34);
#36=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#37=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('z'),$);
#38=IFCWALL('32KlQ7klX9cuTpvX17_zzf',$,$,$,$,$,$,$,$);
#39=IFCPROPERTYSET('0rvcfWIgT4fgCX1B4RtoGt',$,'Foo_Bar',$,(#41));
#40=IFCRELDEFINESBYPROPERTIES('03Y86B3Bf6GfqMksFSTVLS',$,$,$,(#38),#39);
#41=IFCPROPERTYSINGLEVALUE('Foo',$,IFCTIMEMEASURE(2.),$);
#42=IFCWALL('3$KYIGgsH9Vv$4TiBTeTZt',$,$,$,$,$,$,$,$);
#43=IFCPROPERTYSET('0CeS9lcanBbu5bqfFg8ZE8',$,'Foo_Bar',$,(#45));
#44=IFCRELDEFINESBYPROPERTIES('2_n1GE3mfFxRFWpHp18LJc',$,$,$,(#42),#43);
#45=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLENGTHMEASURE(2000.),$);
#46=IFCWALL('1KchI9LNH1Pg25WWTwgmNG',$,$,$,$,$,$,$,$); /* Testcase */
#47=IFCWALLTYPE('3ZoFoQTFfFGOgP93adFcI5',$,$,$,$,(#49),$,$,$,.ELEMENTEDWALL.);
#48=IFCRELDEFINESBYTYPE('0gaofCLiXBf8xM5TVLMcxf',$,$,$,(#46),#47);
#49=IFCPROPERTYSET('2rebcEQmPD9AN2BbtSrvdt',$,'Foo_Bar',$,(#50));
#50=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/pass-properties_can_be_inherited_from_the_type_1_2.ids) - [Sample IFC: 46](testcases/pass-properties_can_be_inherited_from_the_type_1_2.ifc)

## [PASS] Properties can be inherited from the type 2/2

~~~xml
<property minOccurs="1" maxOccurs="1">
  <propertySet>
    <simpleValue>Foo_Bar</simpleValue>
  </propertySet>
  <name>
    <simpleValue>Foo</simpleValue>
  </name>
</property>
~~~

~~~lua
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#20=IFCWALL('18IoQzCPfFqxhHNfS3eHFd',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('1F_evSXS99iRKa$hGUPQy$',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('0zyZ0$bmn7Af7ujZshLMLb',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#24=IFCPROPERTYSET('0s8EpNT$97pxuRRcXV5VKb',$,'Foo_Baz',$,(#26,#27));
#25=IFCRELDEFINESBYPROPERTIES('27UuKxq2H7AxHRiiMU5WML',$,$,$,(#20),#24);
#26=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#27=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#28=IFCWALL('1O_Pve4I54z83jk9EPXg_q',$,$,$,$,$,$,$,$);
#29=IFCPROPERTYSET('1I9KszTPzBbfJFylsO2yZT',$,'Foo_Bar',$,(#31,#32));
#30=IFCRELDEFINESBYPROPERTIES('0GfGT06wv8HAISFMMrpZpk',$,$,$,(#28),#29);
#31=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#32=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#33=IFCWALL('3Uy2pY7ALBTwCdICK_P4$N',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2oZai9eATBqxJ5tVkuOTuY',$,'Foo_Bar',$,(#36,#37));
#35=IFCRELDEFINESBYPROPERTIES('23Gf7Bqm95uREb52AOjFdb',$,$,$,(#33),#34);
#36=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#37=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('z'),$);
#38=IFCWALL('32KlQ7klX9cuTpvX17_zzf',$,$,$,$,$,$,$,$);
#39=IFCPROPERTYSET('0rvcfWIgT4fgCX1B4RtoGt',$,'Foo_Bar',$,(#41));
#40=IFCRELDEFINESBYPROPERTIES('03Y86B3Bf6GfqMksFSTVLS',$,$,$,(#38),#39);
#41=IFCPROPERTYSINGLEVALUE('Foo',$,IFCTIMEMEASURE(2.),$);
#42=IFCWALL('3$KYIGgsH9Vv$4TiBTeTZt',$,$,$,$,$,$,$,$);
#43=IFCPROPERTYSET('0CeS9lcanBbu5bqfFg8ZE8',$,'Foo_Bar',$,(#45));
#44=IFCRELDEFINESBYPROPERTIES('2_n1GE3mfFxRFWpHp18LJc',$,$,$,(#42),#43);
#45=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLENGTHMEASURE(2000.),$);
#46=IFCWALL('1KchI9LNH1Pg25WWTwgmNG',$,$,$,$,$,$,$,$);
#47=IFCWALLTYPE('3ZoFoQTFfFGOgP93adFcI5',$,$,$,$,(#49),$,$,$,.ELEMENTEDWALL.); /* Testcase */
#48=IFCRELDEFINESBYTYPE('0gaofCLiXBf8xM5TVLMcxf',$,$,$,(#46),#47);
#49=IFCPROPERTYSET('2rebcEQmPD9AN2BbtSrvdt',$,'Foo_Bar',$,(#50));
#50=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/pass-properties_can_be_inherited_from_the_type_2_2.ids) - [Sample IFC: 47](testcases/pass-properties_can_be_inherited_from_the_type_2_2.ifc)

## [PASS] Properties can be overriden by an occurrence 1/2

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#20=IFCWALL('18IoQzCPfFqxhHNfS3eHFd',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('1F_evSXS99iRKa$hGUPQy$',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('0zyZ0$bmn7Af7ujZshLMLb',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#24=IFCPROPERTYSET('0s8EpNT$97pxuRRcXV5VKb',$,'Foo_Baz',$,(#26,#27));
#25=IFCRELDEFINESBYPROPERTIES('27UuKxq2H7AxHRiiMU5WML',$,$,$,(#20),#24);
#26=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#27=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#28=IFCWALL('1O_Pve4I54z83jk9EPXg_q',$,$,$,$,$,$,$,$);
#29=IFCPROPERTYSET('1I9KszTPzBbfJFylsO2yZT',$,'Foo_Bar',$,(#31,#32));
#30=IFCRELDEFINESBYPROPERTIES('0GfGT06wv8HAISFMMrpZpk',$,$,$,(#28),#29);
#31=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#32=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#33=IFCWALL('3Uy2pY7ALBTwCdICK_P4$N',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2oZai9eATBqxJ5tVkuOTuY',$,'Foo_Bar',$,(#36,#37));
#35=IFCRELDEFINESBYPROPERTIES('23Gf7Bqm95uREb52AOjFdb',$,$,$,(#33),#34);
#36=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#37=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('z'),$);
#38=IFCWALL('32KlQ7klX9cuTpvX17_zzf',$,$,$,$,$,$,$,$);
#39=IFCPROPERTYSET('0rvcfWIgT4fgCX1B4RtoGt',$,'Foo_Bar',$,(#41));
#40=IFCRELDEFINESBYPROPERTIES('03Y86B3Bf6GfqMksFSTVLS',$,$,$,(#38),#39);
#41=IFCPROPERTYSINGLEVALUE('Foo',$,IFCTIMEMEASURE(2.),$);
#42=IFCWALL('3$KYIGgsH9Vv$4TiBTeTZt',$,$,$,$,$,$,$,$);
#43=IFCPROPERTYSET('0CeS9lcanBbu5bqfFg8ZE8',$,'Foo_Bar',$,(#45));
#44=IFCRELDEFINESBYPROPERTIES('2_n1GE3mfFxRFWpHp18LJc',$,$,$,(#42),#43);
#45=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLENGTHMEASURE(2000.),$);
#46=IFCWALL('1KchI9LNH1Pg25WWTwgmNG',$,$,$,$,$,$,$,$);
#47=IFCWALLTYPE('3ZoFoQTFfFGOgP93adFcI5',$,$,$,$,(#49),$,$,$,.ELEMENTEDWALL.);
#48=IFCRELDEFINESBYTYPE('0gaofCLiXBf8xM5TVLMcxf',$,$,$,(#46),#47);
#49=IFCPROPERTYSET('2rebcEQmPD9AN2BbtSrvdt',$,'Foo_Bar',$,(#50));
#50=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#51=IFCWALL('1fQDAOCajF6xoB5kiOvRUV',$,$,$,$,$,$,$,$); /* Testcase */
#52=IFCWALLTYPE('1PjFVkSvTDZQpyqXUXXpvs',$,$,$,$,(#54),$,$,$,.ELEMENTEDWALL.);
#53=IFCRELDEFINESBYTYPE('1zMW1d8Rz3yxTYbOSgY_sw',$,$,$,(#51),#52);
#54=IFCPROPERTYSET('1Axkxn0Ij03AR_cQx2BXs1',$,'Foo_Bar',$,(#55));
#55=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Baz'),$);
#56=IFCPROPERTYSET('0SA4GG6B92kgidRmR6GCAT',$,'Foo_Bar',$,(#58));
#57=IFCRELDEFINESBYPROPERTIES('1mpNflnbL8NeUzxDhDSwcQ',$,$,$,(#51),#56);
#58=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/pass-properties_can_be_overriden_by_an_occurrence_1_2.ids) - [Sample IFC: 51](testcases/pass-properties_can_be_overriden_by_an_occurrence_1_2.ifc)

## [FAIL] Properties can be overriden by an occurrence 2/2

~~~xml
<property minOccurs="1" maxOccurs="1">
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
#1=IFCPROJECT('1HWECw9Tj64PLmB9tnamZR',$,$,$,$,$,$,$,#6);
#2=IFCSIUNIT(*,.LENGTHUNIT.,.MILLI.,.METRE.);
#3=IFCSIUNIT(*,.AREAUNIT.,.MILLI.,.SQUARE_METRE.);
#4=IFCSIUNIT(*,.VOLUMEUNIT.,.MILLI.,.CUBIC_METRE.);
#5=IFCSIUNIT(*,.TIMEUNIT.,$,.SECOND.);
#6=IFCUNITASSIGNMENT((#5,#3,#4,#2));
#7=IFCWALL('2pYnw5sdf8ovRdrzcIw6$g',$,$,$,$,$,$,$,$);
#8=IFCPROPERTYSET('3_4z1YT$T9IxD4zrMa7Zn5',$,'Foo_Bar',$,(#10,#11));
#9=IFCRELDEFINESBYPROPERTIES('3fJBbxDpz1_w7coQeaBTsY',$,$,$,(#7),#8);
#10=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#11=IFCPROPERTYSINGLEVALUE('Foo',$,IFCBOOLEAN(.F.),$);
#12=IFCWALL('2GXnxdCCTBFBbd7citxXNK',$,$,$,$,$,$,$,$);
#13=IFCPROPERTYSET('13SevpbTfEAvfekG1dzkzd',$,'Foo_Bar',$,(#15));
#14=IFCRELDEFINESBYPROPERTIES('3izOZe$tH02fyuXJsY3uPE',$,$,$,(#12),#13);
#15=IFCPROPERTYSINGLEVALUE('Foo',$,IFCIDENTIFIER('123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345'),$);
#16=IFCWALL('3dq23TNr14igJvSt70maUt',$,$,$,$,$,$,$,$);
#17=IFCPROPERTYSET('0Kz$r5ATf5X8pC$LmeCGTX',$,'Foo_Bar',$,(#19));
#18=IFCRELDEFINESBYPROPERTIES('3DK2m3e2nB38IVs$S77pFo',$,$,$,(#16),#17);
#19=IFCPROPERTYSINGLEVALUE('Foo',$,IFCDURATION('P2D'),$);
#20=IFCWALL('18IoQzCPfFqxhHNfS3eHFd',$,$,$,$,$,$,$,$);
#21=IFCPROPERTYSET('1F_evSXS99iRKa$hGUPQy$',$,'Foo_Bar',$,(#23));
#22=IFCRELDEFINESBYPROPERTIES('0zyZ0$bmn7Af7ujZshLMLb',$,$,$,(#20),#21);
#23=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#24=IFCPROPERTYSET('0s8EpNT$97pxuRRcXV5VKb',$,'Foo_Baz',$,(#26,#27));
#25=IFCRELDEFINESBYPROPERTIES('27UuKxq2H7AxHRiiMU5WML',$,$,$,(#20),#24);
#26=IFCPROPERTYSINGLEVALUE('AnotherProperty',$,IFCLABEL('AnotherValue'),$);
#27=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#28=IFCWALL('1O_Pve4I54z83jk9EPXg_q',$,$,$,$,$,$,$,$);
#29=IFCPROPERTYSET('1I9KszTPzBbfJFylsO2yZT',$,'Foo_Bar',$,(#31,#32));
#30=IFCRELDEFINESBYPROPERTIES('0GfGT06wv8HAISFMMrpZpk',$,$,$,(#28),#29);
#31=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#32=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('y'),$);
#33=IFCWALL('3Uy2pY7ALBTwCdICK_P4$N',$,$,$,$,$,$,$,$);
#34=IFCPROPERTYSET('2oZai9eATBqxJ5tVkuOTuY',$,'Foo_Bar',$,(#36,#37));
#35=IFCRELDEFINESBYPROPERTIES('23Gf7Bqm95uREb52AOjFdb',$,$,$,(#33),#34);
#36=IFCPROPERTYSINGLEVALUE('Foobar',$,IFCLABEL('x'),$);
#37=IFCPROPERTYSINGLEVALUE('Foobaz',$,IFCLABEL('z'),$);
#38=IFCWALL('32KlQ7klX9cuTpvX17_zzf',$,$,$,$,$,$,$,$);
#39=IFCPROPERTYSET('0rvcfWIgT4fgCX1B4RtoGt',$,'Foo_Bar',$,(#41));
#40=IFCRELDEFINESBYPROPERTIES('03Y86B3Bf6GfqMksFSTVLS',$,$,$,(#38),#39);
#41=IFCPROPERTYSINGLEVALUE('Foo',$,IFCTIMEMEASURE(2.),$);
#42=IFCWALL('3$KYIGgsH9Vv$4TiBTeTZt',$,$,$,$,$,$,$,$);
#43=IFCPROPERTYSET('0CeS9lcanBbu5bqfFg8ZE8',$,'Foo_Bar',$,(#45));
#44=IFCRELDEFINESBYPROPERTIES('2_n1GE3mfFxRFWpHp18LJc',$,$,$,(#42),#43);
#45=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLENGTHMEASURE(2000.),$);
#46=IFCWALL('1KchI9LNH1Pg25WWTwgmNG',$,$,$,$,$,$,$,$);
#47=IFCWALLTYPE('3ZoFoQTFfFGOgP93adFcI5',$,$,$,$,(#49),$,$,$,.ELEMENTEDWALL.);
#48=IFCRELDEFINESBYTYPE('0gaofCLiXBf8xM5TVLMcxf',$,$,$,(#46),#47);
#49=IFCPROPERTYSET('2rebcEQmPD9AN2BbtSrvdt',$,'Foo_Bar',$,(#50));
#50=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
#51=IFCWALL('1fQDAOCajF6xoB5kiOvRUV',$,$,$,$,$,$,$,$);
#52=IFCWALLTYPE('1PjFVkSvTDZQpyqXUXXpvs',$,$,$,$,(#54),$,$,$,.ELEMENTEDWALL.); /* Testcase */
#53=IFCRELDEFINESBYTYPE('1zMW1d8Rz3yxTYbOSgY_sw',$,$,$,(#51),#52);
#54=IFCPROPERTYSET('1Axkxn0Ij03AR_cQx2BXs1',$,'Foo_Bar',$,(#55));
#55=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Baz'),$);
#56=IFCPROPERTYSET('0SA4GG6B92kgidRmR6GCAT',$,'Foo_Bar',$,(#58));
#57=IFCRELDEFINESBYPROPERTIES('1mpNflnbL8NeUzxDhDSwcQ',$,$,$,(#51),#56);
#58=IFCPROPERTYSINGLEVALUE('Foo',$,IFCLABEL('Bar'),$);
~~~

[Sample IDS](testcases/fail-properties_can_be_overriden_by_an_occurrence_2_2.ids) - [Sample IFC: 52](testcases/fail-properties_can_be_overriden_by_an_occurrence_2_2.ifc)

