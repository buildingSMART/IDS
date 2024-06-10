# Tolerance value in IDS

## Equality tolerance

Because of rounding errors, a tolerance value must always be considered for the equality of floating-point numbers (doubles in ids:simpleValue and xs:restriction). 

To support both low numbers, like an area of a wire expressed in square meters, and high numbers, like a length of a railway, the IDS uses both a relative and a fixed component, following the formula:

`x == v ⇒ (v - abs(v) × ϵ - ϵ) < x < (v + abs(v) × ϵ + ϵ)` 
with a tolerance value being: `ϵ = 1.0e⁻⁶`

The table below demonstrates characteristic ranges of values within the tolerance:

|v|lower bound<br>`(v - abs(v) × ε - ε)`|	upper bound<br>`(v + abs(v) × ε + ε)`|	absolute delta|
|---:|-------------:|-------------:|--:|
| 100000.0 |		99999.899999 |	100000.100001 |	0.200002 |
| 10000.0	 |	9999.989999	| 10000.010001 |	0.020002 |
| 1000.0	 |	999.998999	| 1000.001001 |	0.002002 |
| 100.0	   |	99.999899	| 100.000101 |	0.000202 |
| 10.0     |		9.999989	| 10.000011 |	2.2E-05 |
| 1.0	|	0.999998	| 1.000002 |	4E-06 |
| 0.1	|	0.0999989	| 0.1000011 |	2.2E-06 |
| 0.01 |		0.00999899 |	0.01000101 |	2.02E-06 |
| 0.001	|	0.000998999	| 0.001001001 |	2.002E-06 |
| 0.0001	|	0.0000989999 |	0.0001010001 |	2.0002E-06 |
| 0.00001	|	0.00000899999 |	0.00001100001 |	2.00002E-06 |
| 0.000001	|	-0.000000000001 |	0.000002000001 |	2.000002E-06 |
| 0.0000001	|	-0.0000009000001 |	0.0000011000001 |	2.0000002E-06 |
| 0	|	-0.000001 |	0.000001 |	2.0E-06 |
| -0.0000001	|	-0.0000011000001 |	0.0000009000001 |	2.0000002E-06 |
| -0.000001	|	-0.0000020000 |	0.000000000001 |	2.000002E-06 |
| -0.00001	|	-0.0000110000 |	-0.00000899999 |	2.00002E-06 |
| -0.0001	|	-0.0001010001 |	-0.0000989999 |	2.0002E-06 |
| -0.001	|	-0.0010010010 |	-0.000998999 |	2.002E-06 |
| -0.01	|	-0.0100010100 |	-0.00999899 |	2.02E-06 |
| -0.1	|	-0.1000011000 |	-0.0999989 |	2.2E-06 |
| -1.0	|	-1.0000020000 |	-0.999998 |	4E-06 |
| -10.0	|	-10.0000110000 |	-9.999989 |	2.2E-05 |
| -100.0	|	-100.0001010000 |	-99.999899 |	0.000202 |
| -1000.0	|	-1000.0010010000 |	-999.998999 |	0.002002 |
| -10000.0	|	-10000.0100010000 |	-9999.989999 |	0.020002 |
| -100000.0	|	-100000.1000010000 |	-99999.899999 |	0.200002 |
| -1000000.0	|	-1000001.0000010000 * |	-999998.999999 |	2.000002 |

\* If the least significant digits are beyond the precision of a IEEE74 double (approximately 17 digits), it might result in a false positive. For example, -1000001.00000100001 would still pass as being equal to -1000000.0, even though being below the lower bound.

Note: the tolerance value is not configurable, as it is specific only for rounding errors, not for construction-related tolerances, for which users need to provide an explicit range.

## Ranges

**The tolerance does not apply to ranges**, as it would open up all kinds of strange edge cases (for example: 41.999958 being both in the range 42-50 inclusive, but also < 42 exclusive). The values used in ranges (minExclusive/minInclusive/maxExclusive/maxInclusive) should therfore be compared explicitly. For example:

| | >1.0 |	>=1.0 |  <1.0 |
|---:|-------------:|-------------:|---------:|
| 0.99999999 | fail |	fail |	pass |
| 1.00000000 | fail |	pass |	fail |
| 1.00000001 | pass |	pass |	fail |

This approach allows for specifying a custom tolerance in cases where the general rule is not applicable. For example:
- `(v - 1e-10) <= x <= (v + 1e-10)` checks that `x` is equal `v` with the custom tolerance of 1e-10, which is much more precise than the default formula
- `v <= x <= v` checks that `x` is exactly equal `v` with no tolerance

# 

Note: the history of these agreements can be traced in the [issue 78](https://github.com/buildingSMART/IDS/issues/78), [issue 36](https://github.com/buildingSMART/IDS/issues/36), and in [the summary by @giuseppeverduciALMA](https://github.com/buildingSMART/IDS/blob/0d50fd8f2dbd5b388f6fafb67da255cc3ce2b4ca/Documentation/tolerance.md).