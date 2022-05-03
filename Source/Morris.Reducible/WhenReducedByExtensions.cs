﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Morris.Reducible;

public static class WhenReducedByExtensions
{
	public static WhenSubStateReducedByBuilder<TState, TSubState, TDelta> WhenReducedBy<TState, TSubState, TDelta>(
		this Builder<TState, TDelta> sourceBuilder,
		Func<TState, TSubState> subStateSelector,
		Func<TSubState, TDelta, ReducerResult<TSubState>> elementReducer)
	=>
		new WhenSubStateReducedByBuilder<TState, TSubState, TDelta>(sourceBuilder, subStateSelector, elementReducer);

	public static WhenImmutableArrayReducedByBuilder<TState, TElement, TDelta> WhenReducedBy<TState, TElement, TDelta>(
		this Builder<TState, TDelta> sourceBuilder,
		Func<TState, ImmutableArray<TElement>> subStateSelector,
		Func<TElement, TDelta, ReducerResult<TElement>> elementReducer)
	=>
		new WhenImmutableArrayReducedByBuilder<TState, TElement, TDelta>(sourceBuilder, subStateSelector, elementReducer);

	public static WhenImmutableListReducedByBuilder<TState, TElement, TDelta> WhenReducedBy<TState, TElement, TDelta>(
		this Builder<TState, TDelta> sourceBuilder,
		Func<TState, ImmutableList<TElement>> subStateSelector,
		Func<TElement, TDelta, ReducerResult<TElement>> elementReducer)
	=>
		new WhenImmutableListReducedByBuilder<TState, TElement, TDelta>(sourceBuilder, subStateSelector, elementReducer);

	public static WhenIEnumerableReducedByBuilder<TState, TElement, TDelta> WhenReducedBy<TState, TElement, TDelta>(
		this Builder<TState, TDelta> sourceBuilder,
		Func<TState, IEnumerable<TElement>> subStateSelector,
		Func<TElement, TDelta, ReducerResult<TElement>> elementReducer)
	=>
		new WhenIEnumerableReducedByBuilder<TState, TElement, TDelta>(sourceBuilder, subStateSelector, elementReducer);
}
