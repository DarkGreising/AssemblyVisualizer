﻿// Adopted, originally created as part of GraphSharp library
// This code is distributed under Microsoft Public License 
// (for details please see \docs\Ms-PL)

using ILSpyVisualizer.Controls.Graph.QuickGraph;

namespace ILSpyVisualizer.Controls.Graph.GraphSharp.Layout
{
    public interface IContextualLayoutAlgorithmFactory<TVertex, TEdge, TGraph> : ILayoutAlgorithmFactory<TVertex, TEdge, TGraph>
        where TVertex : class
        where TEdge : IEdge<TVertex>
        where TGraph : class, IBidirectionalGraph<TVertex, TEdge>
    {
    }
}
