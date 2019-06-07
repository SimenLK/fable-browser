[<AutoOpen>]
module Browser.CssExtensions

open Fable.Core
open Browser.Types

type Document with
    /// Retrieves a collection of styleSheet objects representing the style sheets that correspond to each instance of a link or style object in the document.
    [<Emit("$0.styleSheets{{=$1}}")>]
    member __.styleSheets with get(): StyleSheetList = jsNative and set(v: StyleSheetList) = jsNative
    [<Emit("$0.styleMedia{{=$1}}")>]
    member __.styleMedia with get(): StyleMedia = jsNative and set(v: StyleMedia) = jsNative
    [<Emit("$0.getComputedStyle($1...)")>]
    member __.getComputedStyle(elt: Element, ?pseudoElt: string): CSSStyleDeclaration = jsNative
    [<Emit("$0.getMatchedCSSRules($1...)")>]
    member __.getMatchedCSSRules(elt: Element, ?pseudoElt: string): CSSRuleList = jsNative

type HTMLElement with
    [<Emit("$0.style{{=$1}}")>]
    member __.style with get(): CSSStyleDeclaration = jsNative and set(v: CSSStyleDeclaration) = jsNative

type HTMLLinkElement with
    [<Emit("$0.sheet{{=$1}}")>]
    member __.sheet with get(): StyleSheet = jsNative and set(v: StyleSheet) = jsNative

type HTMLStyleElement with
    [<Emit("$0.sheet{{=$1}}")>]
    member __.sheet with get(): StyleSheet = jsNative and set(v: StyleSheet) = jsNative

type SVGStylable with
    [<Emit("$0.style{{=$1}}")>]
    member __.style with get(): CSSStyleDeclaration = jsNative and set(v: CSSStyleDeclaration) = jsNative

type SVGSVGElement with
    [<Emit("$0.getComputedStyle($1...)")>]
    member __.getComputedStyle(elt: Element, ?pseudoElt: string): CSSStyleDeclaration = jsNative
