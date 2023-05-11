// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace CSharp.HistoryExplorer.Models;

public sealed class History
{
    public static IReadOnlySet<TimelineEntry> Items { get; } = new HashSet<TimelineEntry>
    {
        new(
            Date: new DateOnly(2002, 1, 1),
            Version: new(1),
            Reference: "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-version-history#c-version-10-1",
            Details: new[]
            {
                new EntryDetail("Classes (`class` type)", "classes.md", "https://learn.microsoft.com/dotnet/csharp/fundamentals/types/classes"),
                new EntryDetail("Structs (`struct` type)","structs.md", "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/struct"),
                new EntryDetail("Interfaces (`interface` type)","interfaces.md", "https://learn.microsoft.com/dotnet/csharp/fundamentals/types/interfaces"),
                new EntryDetail("Events (`event` keyword)", "events.md","https://learn.microsoft.com/dotnet/csharp/events-overview"),
                new EntryDetail("Properties", "properties.md","https://learn.microsoft.com/dotnet/csharp/properties"),
                new EntryDetail("Delegates (`delegate`)","delegates.md", "https://learn.microsoft.com/dotnet/csharp/delegates-overview"),
                new EntryDetail("Operators and expressions","operators-and-expressions.md","https://learn.microsoft.com/dotnet/csharp/language-reference/operators/"),
                new EntryDetail("Statements","statements.md","https://learn.microsoft.com/dotnet/csharp/programming-guide/statements-expressions-operators/statements"),
                new EntryDetail("Attributes", "attributes.md","https://learn.microsoft.com/dotnet/csharp/advanced-topics/reflection-and-attributes"),
            }),

        new(
            Date: new DateOnly(2003, 1, 1),
            Version: new(1, 2),
            Reference: "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-version-history#c-version-12",
            Details: new[]
            {
                new EntryDetail("Introduced `foreach` loop calls `IDisposable.Dispose`", ".md", "foreach.md")
            }),

        new(
            Date: new DateOnly(2005, 11, 1),
            Version: new(2),
            Reference: "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-version-history#c-version-20",
            Details: new[]
            {
                new EntryDetail("Generics", "generics.md","https://learn.microsoft.com/dotnet/csharp/fundamentals/types/generics"),
                new EntryDetail("Partial (`partial`) types", "partial.md","https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods#partial-classes"),
                new EntryDetail("Anonymous methods", "anonymous-methods.md","https://learn.microsoft.com/dotnet/csharp/language-reference/operators/delegate-operator"),
                new EntryDetail("Nullable value types", "nullable-value-types.md","https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/nullable-value-types"),
                new EntryDetail("Iterators", "iterators.md","https://learn.microsoft.com/dotnet/csharp/programming-guide/concepts/iterators"),
                new EntryDetail("Covariance and contravariance", "variance.md","https://learn.microsoft.com/dotnet/csharp/programming-guide/concepts/covariance-contravariance/"),
                new EntryDetail("Getter/setter separate accessibility", ".md", "getter-setter.md"),
                new EntryDetail("Method group conversion (`delegate`)", ".md", "method-group-conversion.md"),
                new EntryDetail("Introduced `static` classes", ".md", "static-classes.md"),
                new EntryDetail("Delegate inference", ".md", "delegate-inference.md"),
            }),

        new(
            Date: new DateOnly(2007, 11, 1),
            Version: new(3),
            Reference: "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-version-history#c-version-30",
            Details: new[]
            {
                new EntryDetail("Auto-implemented properties", "auto-implemented-properties.md", "https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties"),
                new EntryDetail("Anonymous types", "anonymous-types.md", "https://learn.microsoft.com/dotnet/csharp/fundamentals/types/anonymous-types"),
                new EntryDetail("Query expressions", "query-expressions.md","https://learn.microsoft.com/dotnet/csharp/linq/query-expression-basics"),
                new EntryDetail("Lambda expressions", "lambda-expressions.md","https://learn.microsoft.com/dotnet/csharp/language-reference/operators/lambda-expressions"),
                new EntryDetail("Expression trees", "expression-trees.md","https://learn.microsoft.com/dotnet/csharp/advanced-topics/expression-trees"),
                new EntryDetail("Extensions methods", "extension-methods.md","https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods"),
                new EntryDetail("Implicitly typed local variables (`var` type)", "var.md","https://learn.microsoft.com/dotnet/csharp/language-reference/statements/declarations#implicitly-typed-local-variables"),
                new EntryDetail("Introduced `partial` methods", "partial-methods.md", "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/partial-method"),
                new EntryDetail("Object and collection initializers", "object-and-collection-init.md", "https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers"),
            }),

        new(
            Date: new DateOnly(2010, 4, 1),
            Version: new(4),
            Reference: "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-version-history#c-version-40",
            Details: new[]
            {
                new EntryDetail("Dynamic binding (`dynamic` type)", "dynamic.md","https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/reference-types"),
                new EntryDetail("Named/optional arguments", "named-args.md","https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments"),
                new EntryDetail("Generic covariant and contravariant", "generic-variance.md","https://learn.microsoft.com/dotnet/standard/generics/covariance-and-contravariance"),
                new EntryDetail("Embedded interop types", "embedded-interop.md","https://learn.microsoft.com/dotnet/framework/interop/type-equivalence-and-embedded-interop-types"),
            }),

        new(
            Date: new DateOnly(2012, 10, 1),
            Version: new(5),
            Reference: "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-version-history#c-version-50",
            Details: new[]
            {
                new EntryDetail("Asynchronous members (`async` and `await`)", "async-await.md","https://learn.microsoft.com/dotnet/csharp/asynchronous-programming/"),
                new EntryDetail("Caller info attributes", "caller-info-attributes.md","https://learn.microsoft.com/dotnet/csharp/language-reference/attributes/caller-information"),
            }),

        new(
            Date: new DateOnly(2015, 7, 1),
            Version: new(6),
            Reference: "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-version-history#c-version-60",
            Details: new[]
            {
                new EntryDetail("Static imports (`using static`)", "using-static.md","https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/using-directive"),
                new EntryDetail("Exception filters, i.e.; `when (<expression>)`", "exception-filters.md","https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/when"),
                new EntryDetail("Auto-property initializers", "auto-property-init.md","https://learn.microsoft.com/dotnet/csharp/properties"),
                new EntryDetail("Expression-bodied members", "expression-bodied-members.md","https://learn.microsoft.com/dotnet/csharp/language-reference/operators/lambda-operator#expression-body-definition"),
                new EntryDetail("Null propagator", "null-propagator.md","https://learn.microsoft.com/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-"),
                new EntryDetail("String interpolation", "string-interpolation.md","https://learn.microsoft.com/dotnet/csharp/language-reference/tokens/interpolated"),
                new EntryDetail("Introduced `nameof` operator", "nameof.md","https://learn.microsoft.com/dotnet/csharp/language-reference/operators/nameof")
            }),

        new(
            Date: new DateOnly(2017, 3, 1),
            Version: new(7),
            Reference: "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-version-history#c-version-70",
            Details: new[]
            {
                new EntryDetail("Out variables (`out var x`)", ".md", "out-var.md"),
                new EntryDetail("Tuples (`ValueTuple`) and deconstruction","value-tuples.md", "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/value-tuples"),
                new EntryDetail("Pattern matching", "pattern-matching.md","https://learn.microsoft.com/dotnet/csharp/fundamentals/functional/pattern-matching"),
                new EntryDetail("Local functions", "local-functions.md","https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/local-functions"),
                new EntryDetail("Expanded expression bodied members", "expanded-expression-bodied-members.md","https://learn.microsoft.com/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members"),
                new EntryDetail("Introduced `ref` locals", "ref-locals.md","https://learn.microsoft.com/dotnet/csharp/language-reference/statements/declarations#ref-locals"),
                new EntryDetail("Introduced `ref` returns", "ref-returns.md","https://learn.microsoft.com/dotnet/csharp/language-reference/statements/jump-statements#ref-returns"),
                new EntryDetail("Discards (`_`)", "discards.md","https://learn.microsoft.com/dotnet/csharp/fundamentals/functional/discards"),
                new EntryDetail("Binary literals and digit separators", ".md", "binary-literals.md"),
                new EntryDetail("Throw expressions (`?? throw`)", "throw-expressions.md","https://learn.microsoft.com/dotnet/csharp/language-reference/statements/exception-handling-statements#the-throw-expression"),
            }),

        new(
            Date: new DateOnly(2017, 8, 1),
            Version: new(7, 1),
            Reference: "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-version-history#c-version-71",
            Details: new[]
            {
                new EntryDetail("Introduced `async Main`", "async-main.md","https://learn.microsoft.com/dotnet/csharp/fundamentals/program-structure/main-command-line"),
                new EntryDetail("Introduced `default` literals expressions", "default-literals.md","https://learn.microsoft.com/dotnet/csharp/language-reference/operators/default#default-literal"),
                new EntryDetail("Inferred tuple element names", ".md", "inferred-tuple-names.md"),
                new EntryDetail("Pattern matching on generic type parameters", ".md", "pattern-matching-generic.md"),
            }),

        new(
            Date: new DateOnly(2017, 11, 1),
            Version: new(7, 2),
            Reference: "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-version-history#c-version-72",
            Details: new[]
            {
                new EntryDetail("Initializers on `stackalloc` arrays", ".md"),
                new EntryDetail("Use `fixed` statements on any valid pattern", ".md"),
                new EntryDetail("Access `fixed` fields without pinning", ".md"),
                new EntryDetail("Reassign `ref` local variables", ".md"),
                new EntryDetail("Declare `readonly struct` types", ".md"),
                new EntryDetail("Parameter `in` modifier", ".md"),
                new EntryDetail("Use `ref readonly` modifier on method `return`", ".md"),
                new EntryDetail("Declare `ref struct` types", ".md"),
                new EntryDetail("Additional generic constraints", ".md"),
                new EntryDetail("Non-trailing named arguments", ".md", "https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments"),
                new EntryDetail("Leading underscores in numeric literals", ".md"),
                new EntryDetail("Introduced `private protected` access modifier", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/access-modifiers"),
                new EntryDetail("Conditional `ref` expressions", ".md"),
            }),

        new(
            Date: new DateOnly(2018, 5, 1),
            Version: new(7, 3),
            Reference: "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-version-history#c-version-73",
            Details: new[]
            {
                new EntryDetail("Introduced `==` and `!=` with tuple types", ".md"),
                new EntryDetail("Attach attributes to the backing field of auto-implemented properties", ".md"),
                new EntryDetail("Method resolution when arguments differ by `in`", ".md"),
                new EntryDetail("Overload resolution has few ambiguous cases", ".md"),
            }),

        new(
            Date: new DateOnly(2019, 9, 1),
            Version: new(8),
            Reference: "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-version-history#c-version-80",
            Details: new[]
            {
                new EntryDetail("Introduced `readonly` members", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/struct#readonly-instance-members"),
                new EntryDetail("Default interface methods", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/interface#default-interface-members"),
                new EntryDetail("Pattern matching: switch expression enhancements", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/patterns"),
                new EntryDetail("Pattern matching: property expression enhancements", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/patterns"),
                new EntryDetail("Pattern matching: tuple expression enhancements", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/patterns"),
                new EntryDetail("Pattern matching: positional expression enhancements",".md",  "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/patterns"),
                new EntryDetail("Introduced `using` declarations", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/using-directive"),
                new EntryDetail("Introduced `static` local functions",".md",  "https://learn.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/local-functions"),
                new EntryDetail("Disposable `ref struct`",".md",  "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/ref-struct"),
                new EntryDetail("Nullable reference types",".md",  "https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/nullable-reference-types"),
                new EntryDetail("Introduced asynchronous streams (`await foreach`)",".md",  "https://learn.microsoft.com/dotnet/csharp/language-reference/statements/iteration-statements#await-foreach"),
                new EntryDetail("Null-coalescing assignment (`??=`)",".md",  "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/assignment-operator#null-coalescing-assignment"),
                new EntryDetail("Unmanaged constructed types",".md",  "https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/where-generic-type-constraint"),
                new EntryDetail("Introduced `stackalloc` in nested expressions", ".md",  "https://learn.microsoft.com/dotnet/csharp/language-reference/operators/stackalloc"),
                new EntryDetail("Enhancement of interpolated verbatim string", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/tokens/interpolated"),
            }),

        new(
            Date: new DateOnly(2020, 11, 1),
            Version: new(9),
            Reference: "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-version-history#c-version-90",
            Details: new[]
            {
                new EntryDetail("Introduced `record` types", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-9#record-types"),
                new EntryDetail("Init-only property setter", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-9#init-only-setters"),
                new EntryDetail("Top-level statements", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-9#top-level-statements"),
                new EntryDetail("Pattern matching enhancements", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-9#pattern-matching-enhancements"),
                new EntryDetail("Native sized integers", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/proposals/csharp-9.0/native-integers"),
                new EntryDetail("Function pointers", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/proposals/csharp-9.0/function-pointers"),
                new EntryDetail("Suppress emitting `localsinit` flag", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/proposals/csharp-9.0/skip-localsinit"),
                new EntryDetail("Target-type `new` expressions", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/proposals/csharp-9.0/target-typed-new"),
                new EntryDetail("Introduced `static` anonymous functions", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/proposals/csharp-9.0/static-anonymous-functions"),
                new EntryDetail("Target-type conditional expressions", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/proposals/csharp-9.0/target-typed-conditional-expression"),
                new EntryDetail("Covariant return types", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/proposals/csharp-9.0/covariant-returns"),
                new EntryDetail("Extension `GetEnumerator` support for `foreach` loops", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/proposals/csharp-9.0/extension-getenumerator"),
                new EntryDetail("Lambda discard parameters", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/proposals/csharp-9.0/lambda-discard-parameters"),
                new EntryDetail("Attributes on local functions", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/proposals/csharp-9.0/local-function-attributes"),
                new EntryDetail("Introduced `with` expressions", ".md"),
                new EntryDetail("Source generators: module initializers", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/proposals/csharp-9.0/module-initializers"),
                new EntryDetail("Source generators: new features for `partial` methods", ".md", "https://learn.microsoft.com/dotnet/csharp/language-reference/proposals/csharp-9.0/extending-partial-methods"),
            }),

        new(
            Date: new DateOnly(2021, 11, 1),
            Version: new(10),
            Reference: "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-version-history#c-version-10",
            Details: new[]
            {
                new EntryDetail("Introduced `record struct` types", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-10#record-structs"),
                new EntryDetail("Improvements on structure types", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-10#improvements-of-structure-types"),
                new EntryDetail("Interpolated string handlers", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-10#interpolated-string-handler"),
                new EntryDetail("Introduced `global using` directives", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-10#global-using-directives"),
                new EntryDetail("File-scoped namespace declaration", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-10#file-scoped-namespace-declaration"),
                new EntryDetail("Extended property patterns", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-10#extended-property-patterns"),
                new EntryDetail("Improvements on lambda expressions", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-10#lambda-expression-improvements"),
                new EntryDetail("Allow `const` interpolated strings", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-10#constant-interpolated-strings"),
                new EntryDetail("Record types can `public override sealed string ToString()`", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-10#record-types-can-seal-tostring"),
                new EntryDetail("Improved definite assignment", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-10#improved-definite-assignment"),
                new EntryDetail("Allow both assignment and declaration in the same deconstruction", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-10#assignment-and-declaration-in-same-deconstruction"),
                new EntryDetail("Allow `AsyncMethodBuilder` attribute on methods", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-10#allow-asyncmethodbuilder-attribute-on-methods"),
                new EntryDetail("Introduced `CallerArgumentExpression` attribute", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-10#callerargumentexpression-attribute-diagnostics"),
                new EntryDetail("Enhanced `#line pragma`", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-10#enhanced-line-pragma"),
                new EntryDetail("Introduced `static abstract` members in interfaces", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-11#generic-math-support"),
            }),

        new(
            Date: new DateOnly(2022, 11, 1),
            Version: new(11),
            Reference: "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-version-history#c-version-11",
            Details: new[]
            {
                new EntryDetail("Raw `string` literals", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-11#raw-string-literals"),
                new EntryDetail("Generic math support", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-11#generic-math-support"),
                new EntryDetail("Generic attributes", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-11#generic-attributes"),
                new EntryDetail("UTF-8 `string` literals", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-11#utf-8-string-literals"),
                new EntryDetail("Newlines in `string` interpolation expressions", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-11#newlines-in-string-interpolations"),
                new EntryDetail("List patterns", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-11#list-patterns"),
                new EntryDetail("File-local types", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-11#file-local-types"),
                new EntryDetail("Required (`required`) members", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-11#required-members"),
                new EntryDetail("Auto-default structs", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-11#auto-default-struct"),
                new EntryDetail("Pattern match `Span<char>` on a constant `string`", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-11#pattern-match-spanchar-or-readonlyspanchar-on-a-constant-string"),
                new EntryDetail("Extended `nameof` scope", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-11#extended-nameof-scope"),
                new EntryDetail("Numeric `IntPtr`", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-11#numeric-intptr-and-uintptr"),
                new EntryDetail("Introduced `ref` fields and scoped `ref`", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-11#ref-fields-and-ref-scoped-variables"),
                new EntryDetail("Improved method group conversion to `delegate`", ".md", "https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-11#improved-method-group-conversion-to-delegate"),
            }),
    };
}
