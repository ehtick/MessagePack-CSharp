﻿// Copyright (c) All contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Immutable;

namespace MessagePack.Analyzers.CodeAnalysis;

/// <summary>
/// Options for the analyzer and source generator, which may be deserialized from a MessagePackAnalyzer.json file.
/// </summary>
public record AnalyzerOptions
{
    /// <summary>
    /// Gets the set fully qualified names of types that are assumed to have custom formatters written that will be included by a resolver by the program.
    /// </summary>
    public ImmutableHashSet<string> AssumedFormattableTypes { get; init; } = ImmutableHashSet<string>.Empty;

    /// <summary>
    /// Gets the set fully qualified names of custom formatters that should be considered by the analyzer and included in the generated resolver,
    /// and the collection of types that they can format.
    /// </summary>
    public ImmutableDictionary<string, ImmutableHashSet<string>> KnownFormatters { get; init; } = ImmutableDictionary<string, ImmutableHashSet<string>>.Empty;

    public GeneratorOptions Generator { get; init; } = new();

    public string FormatterNamespace => this.Generator.Formatters.Namespace;

    /// <summary>
    /// Gets a value indicating whether the analyzer is generating source code.
    /// </summary>
    public bool IsGeneratingSource { get; init; }
}

/// <summary>
/// Customizes aspects of source generated formatters.
/// </summary>
public record FormattersOptions
{
    // TODO: Remove this, since formatters should be generated into the resolver class.
    /// <summary>
    /// Gets the root namespace into which formatters are emitted.
    /// </summary>
    public string Namespace { get; init; } = "Formatters";
}

/// <summary>
/// Describes the generated resolver.
/// </summary>
public record ResolverOptions
{
    /// <summary>
    /// Gets the name to use for the resolver.
    /// </summary>
    public string Name { get; init; } = "GeneratedMessagePackResolver";

    /// <summary>
    /// Gets the namespace the source generated resolver will be emitted into.
    /// </summary>
    public string? Namespace { get; init; } = "MessagePack";
}

/// <summary>
/// Customizes AOT source generation of formatters for custom types.
/// </summary>
public record GeneratorOptions
{
    /// <summary>
    /// Gets a value indicating whether types will be serialized with their property names as well as their values in a key=value dictionary, as opposed to an array of values.
    /// </summary>
    public bool UsesMapMode { get; init; }

    /// <summary>
    /// Gets options for the generated resolver.
    /// </summary>
    public ResolverOptions Resolver { get; init; } = new();

    /// <summary>
    /// Gets options for the generated formatter.
    /// </summary>
    public FormattersOptions Formatters { get; init; } = new();
}
