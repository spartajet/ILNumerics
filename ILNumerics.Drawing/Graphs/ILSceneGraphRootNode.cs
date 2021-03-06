#region Copyright GPLv3
//
//  This file is part of ILNumerics.Net. 
//
//  ILNumerics.Net supports numeric application development for .NET 
//  Copyright (C) 2007, H. Kutschbach, http://ilnumerics.net 
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//   along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 
//  Non-free licenses are also available. Contact info@ilnumerics.net 
//  for details.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using ILNumerics.Drawing; 
using ILNumerics.Drawing.Controls; 

namespace ILNumerics.Drawing.Graphs {

    /// <summary>
    /// the root node of every scene graph (internal use only) 
    /// </summary>
    internal class ILSceneGraphRoot : ILSceneGraphInnerNode {
        
        public event SceneGraphNodeHandler NodeAdded; 
        public event SceneGraphNodeHandler NodeRemoved;  
        
        public ILSceneGraphRoot(ILPanel panel) : base(panel) { }

        protected override void OnNodeAdded(ILSceneGraphNode node) {
            if (NodeAdded != null && !m_eventingSuspended) {
                NodeAdded(this, new ILSceneGraphNodeEventArgs(node)); 
            }
        }
        protected override void OnNodeRemoved(ILSceneGraphNode node) {
            if (NodeRemoved != null && !m_eventingSuspended) {
                NodeRemoved(this, new ILSceneGraphNodeEventArgs(node)); 
            }
        }
    }
}
