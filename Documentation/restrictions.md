# Complex restrictions

When specifying a **Facet Parameter**, you may either specify a **Simple Value** or a **Complex Restriction**. A **Simple Value** may be text, a number, or a boolean (TRUE / FALSE). In contrast, a **Complex Restriction** may represent pick lists of valid values, naming schemes and conventions, numeric ranges, or more. A restriction may be specified in six different ways:

 - Enumeration
 - Pattern
 - Bounds
 - Length
 - Total digits
 - Fraction digits

## Enumeration

An **Enumeration** restriction means that the value must be one of a list of allowed values. For example, you might want to specify that a material may be either "concrete" or "steel".

Numbers may also be specified as a list. For example, you may specify that a concrete strength grade may be either "25", "30", "35, or "40". If the user has the value of "30", then that will comply with your **Enumeration**. However, if they choose "31", then it does not.

Booleans may also be specified, such as "TRUE" or "FALSE". However, it is generally meaningless to specify a boolean as an enumeration because the nature of a boolean implies that the user always has to choose either "TRUE" or "FALSE".

Note that even if you specify a list of allowed values, the user can still only choose one value from that list.

## Pattern

A **Pattern** restriction represents a naming convention or naming scheme. For example, if you want to specify that door types must be named using the convention DT01, DT02, DT03, etc, you can create a pattern defining that the letters "DT" should be first, followed by two numbers.

Computers have a special way of defining patterns of text called **Regex**. It uses special symbols to tell the computer to expect numbers, letters, or any character. You may already be familiar with computer patterns using the "`*`" character as a wildcard. For example, you might say that the pattern "`DT*`" can be satisfied by the values "`DTA`", "`DTB`", or even "`DT01`". **Regex** is a bit more complex, but in exchange, you can be more specific about the rules in your pattern. Investing in learning **Regex** is highly recommended, given the importance of naming conventions in the AEC industry.

Here are some common examples you can use:

Pattern | Description | Example values that meet the pattern criteria | Example values that fail the pattern
--- | --- | --- | ---
`DT01` | When only letters and numbers are used with no symbols, then the pattern is equivalent to an exact match | "`DT01`" | Anything other than "`DT01`" will fail.
`DT_ABC-01` | Apart from letters and numbers, the "`_`" and "`-`" symbols have no special meaning, so this pattern is also equivalent to an exact match. | "`DT_ABC-01`" | Anything other than "`DT_ABC-01`" will fail.
`DT.` | The "`.`" symbol is a wildcard for any _single_ character. | "`DT1`", "`DT2`", "`DTA`", "`DTX`", "`DT+`", etc | "`DT01`" will not match because it has multiple characters after "`DT`". "`ADT1`" will not match because it starts with "`A`", not "`DT`".
`DT..` | When the "`.`" wildcard symbol is used multiple times, each time represents another _single_ character. | "`DT01`", "`DT02`", "`DTAB`", "`DTXY`", "`DT++`", etc | "`DT1`" will not match because it doesn't have two characters after "`DT`".
`DT.*` | When the "`*`" symbol is used after the "`.`" symbol to create "`.*`", it is a wildcard for any number of characters, not just a single character. So anything starting with `DT` will match, regardless of what characters are after it. | "`DT1`", "`DT02`", "`DTA`", "`DTXYZ`", "`DT+1-BC=123`", etc | Anything that doesn't start with "`DT`" will fail, such as "`ADT`", "`ABC-DT01`", etc.
`.*DT.*` | This time, the "`.*`" symbol combination is used both before and after the text "`DT`", meaning that any number of characters (including zero characters) can occur before or after the text "`DT`". | "`DT`" matches because it technically has zero characters before and after it (tricky, isn't it?). "`DT1`", "`ADT`", "`ADT1`", "`ABCDT01`", and "`ABC-DT-01`" all match. | Anything which doesn't contain "`DT`" will fail, such as "`ADIT`", "`TD`", or "`D-T`".
`DT[0-9]` | The "`[0-9]`" symbol combination means that any _single_ digit between 0 and 9 is allowed after the text "`DT`". | "`DT0`", "`DT1`", "`DT2`" up to "`DT9`" will all match | Anything which doesn't have _only_ a single digit after "`DT`" will fail, like "`DT`", "`DTA`", and "`DT123`"
`DT[0-9]*` | When the "`*`" symbol is used after the "`[0-9]`" symbol to create "`[0-9]*`", it means that you can have any number of digits (including zero!) after the text "`DT`". | "`DT`", "`DT1`", "`DT12`", "`DT012345`", etc will match | Any value which has a non-digit after "`DT`" will fail, like "`DTABC`", "`DT01A`", "DTA1B2", etc.
`DT[0-9]{2}` | This time, instead of adding the "`*`" symbol, we add the "`{2}`" symbol, which means that you want exactly two digits after "`DT`". | "`DT01`", "`DT24`", "`DT99`", etc all match | Anything other than 2 digits will fail, like "`DTA`", "`DT0`", or "`DT123`".

**Regex** is a well-established methodology and can achieve very advanced pattern matching, but can take a while to fully learn its capabilities. As a result, only a few basic examples are shown here. Teaching the full capabilities is outside the scope of the IDS documentation. To make full use of it, there are plenty of online tutorials and resources:

 - [Beginners Regex tutorial](https://regexone.com/)
 - [Online Regex testing website](https://regex101.com/)
 - [XML Regular expressions](https://www.regular-expressions.info/xml.html)

Note that Regex has multiple "flavours" or "dialects", so although the first two links are useful learning resources, they may also include Regex features not available in IDS. The third link (XML Regular expressions) can be referenced as an authoritative source on what can be used in IDS. In general, Regex in IDS is simpler and does not include advanced Regex features.

## Bounds

A **Bounds** restriction allows you to specify that the value is a number and has to fall within a range of values. You can specify either a minimum, maximum, or both. You can also specify whether the minimum or maximum is inclusive (e.g. `>=` and `<=`) or exclusive (e.g. `>` and `<`). For example, you might specify that a value needs to be "more than 3" and "less than or equal to 10".

## Length

A **Length** restriction specifies the exact number of characters allowed in a value. For example, if you specify a length of 3, then values that are three characters long, like "`ABC`" or "`123`", will meet your requirement. Other values, like "`AB`" or "`ABC123`" will not meet your requirement.

Note that it is also possible to achieve the same effect by specifying a **Pattern**, such as "`.{3}`", however, the **Length** restriction is simpler and quicker to compute.

## Total digits

A **Total Digits** restriction specifies the total number of digits allowed in a value, regardless of negative signs or decimal points. For example, a **Total Digits** of 3 mean that "`123`", "`-123`", and "`1.23`" all meet the requirement.

## Fraction digits

A **Fraction Digits** restriction specifies the precision of the digits allowed after the decimal point. For example, a value of 3 means that "`12`", "`12.3`", "`12.34`", and "`12.345`" are all allowed, since they have three or less digits after the decimal point. However, "`12.3456`" is not allowed. Note that "`12.3450`", "`12.34500`", etc are all equivalent to "`12.345`", so they are also allowed. However, "`12.3450001`" is not equivalent so it is not allowed.
