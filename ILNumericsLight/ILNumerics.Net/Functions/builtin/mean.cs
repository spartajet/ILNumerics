//////////////////////////////////////////////////////////////////
//                                                              //
//  This is an auto - manipulated source file.                  //
//  Edits inside regions of HYCALPER AUTO GENERATED CODE        //
//  will be lost and overwritten on the next build!             //
//                                                              //
//////////////////////////////////////////////////////////////////
#region LGPL License
/*    
    This file is part of ILNumerics.Net Core Module.

    ILNumerics.Net Core Module is free software: you can redistribute it 
    and/or modify it under the terms of the GNU Lesser General Public 
    License as published by the Free Software Foundation, either version 3
    of the License, or (at your option) any later version.

    ILNumerics.Net Core Module is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with ILNumerics.Net Core Module.  
    If not, see <http://www.gnu.org/licenses/>.
*/
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using ILNumerics.Storage;
using ILNumerics.Misc;
using ILNumerics.Exceptions;
using ILNumerics.BuiltInFunctions;
/*!HC:TYPELIST:
<hycalper>
<type>
    <source>
        inCls1
    </source>
    <destination><![CDATA[ILArray<complex>]]></destination>
    <destination><![CDATA[ILArray<byte>]]></destination>
</type>
<type>
    <source>
        outCls1
    </source>
    <destination><![CDATA[ILArray<complex>]]></destination>
    <destination><![CDATA[ILArray<byte>]]></destination>
</type>
<type>
    <source>
        inArr2
    </source>
    <destination>complex</destination>
    <destination>byte</destination>
</type>
<type>
    <source>
        outArr1
    </source>
    <destination>complex</destination>
    <destination>byte</destination>
</type>
</hycalper>
*/

namespace ILNumerics.BuiltInFunctions  {
	public partial class ILMath {
        #region HYCALPER LOOPSTART 
        /// <summary>
        /// Mean 
        /// </summary>
        /// <param name="A">N-dimensional array</param>
        /// <returns>mean of elements along first non singleton dimension</returns>
        /// <remarks>the array returned will be a physical array. The number 
        /// of its dimensions will be the number of dimensions of A minus 1. If A is scalar,
        /// the value returned will be scalar. The type will be the same type as A.</remarks>
        public static /*!HC:outCls1*/ ILArray<double> mean(/*!HC:inCls1*/ ILArray<double> A) {
            return mean(A,-1); 
        }
        /// <summary>
        /// Mean 
        /// </summary>
        /// <param name="A">N-dimensional array</param>
        /// <param name="dim">dimension index to gather the mean along</param>
        /// <returns>mean of elements along dimension dim</returns>
        /// <remarks>the array returned will be a new solid physical array. The number
        /// of its dimensions will be the number of dimensions of A minus 1. If A is scalar,
        /// the value returned will be scalar. The type will be the same type as A.</remarks>
        public static /*!HC:outCls1*/ ILArray<double> mean(/*!HC:inCls1*/ ILArray<double> A, int dim) {
            if (dim < 0)
                dim = A.m_dimensions.FirstNonSingleton();
            if (dim < 0)
                dim = 0;
            /*!HC:outCls1*/ ILArray<double> ret = sum(A, dim) / (/*!HC:outArr1*/ double )A.m_dimensions[dim];
            return ret;
        }
        #endregion HYCALPER LOOPEND
#region HYCALPER AUTO GENERATED CODE
// DO NOT EDIT INSIDE THIS REGION !! CHANGES WILL BE LOST !! 
        /// <summary>
        /// Mean 
        /// </summary>
        /// <param name="A">N-dimensional array</param>
        /// <returns>mean of elements along first non singleton dimension</returns>
        /// <remarks>the array returned will be a physical array. The number 
        /// of its dimensions will be the number of dimensions of A minus 1. If A is scalar,
        /// the value returned will be scalar. The type will be the same type as A.</remarks>
        public static  ILArray<byte> mean( ILArray<byte> A) {
            return mean(A,-1); 
        }
        /// <summary>
        /// Mean 
        /// </summary>
        /// <param name="A">N-dimensional array</param>
        /// <param name="dim">dimension index to gather the mean along</param>
        /// <returns>mean of elements along dimension dim</returns>
        /// <remarks>the array returned will be a new solid physical array. The number
        /// of its dimensions will be the number of dimensions of A minus 1. If A is scalar,
        /// the value returned will be scalar. The type will be the same type as A.</remarks>
        public static  ILArray<byte> mean( ILArray<byte> A, int dim) {
            if (dim < 0)
                dim = A.m_dimensions.FirstNonSingleton();
            if (dim < 0)
                dim = 0;
            ILArray<byte> ret = sum(A, dim) / ( byte )A.m_dimensions[dim];
            return ret;
        }
        /// <summary>
        /// Mean 
        /// </summary>
        /// <param name="A">N-dimensional array</param>
        /// <returns>mean of elements along first non singleton dimension</returns>
        /// <remarks>the array returned will be a physical array. The number 
        /// of its dimensions will be the number of dimensions of A minus 1. If A is scalar,
        /// the value returned will be scalar. The type will be the same type as A.</remarks>
        public static  ILArray<complex> mean( ILArray<complex> A) {
            return mean(A,-1); 
        }
        /// <summary>
        /// Mean 
        /// </summary>
        /// <param name="A">N-dimensional array</param>
        /// <param name="dim">dimension index to gather the mean along</param>
        /// <returns>mean of elements along dimension dim</returns>
        /// <remarks>the array returned will be a new solid physical array. The number
        /// of its dimensions will be the number of dimensions of A minus 1. If A is scalar,
        /// the value returned will be scalar. The type will be the same type as A.</remarks>
        public static  ILArray<complex> mean( ILArray<complex> A, int dim) {
            if (dim < 0)
                dim = A.m_dimensions.FirstNonSingleton();
            if (dim < 0)
                dim = 0;
            ILArray<complex> ret = sum(A, dim) / ( complex )A.m_dimensions[dim];
            return ret;
        }

#endregion HYCALPER AUTO GENERATED CODE
    }
}
namespace ILNumerics.Untyped {
    public sealed partial class ILUntype {
        /// <summary>
        /// mean of array A
        /// </summary>
        /// <param name="inParameters">variable input parameter of type ILBaseArray. 
        /// <list type="bullet">
        /// <item> mean(A), where A is an ILArray of type supported, will give the 
        /// mean along the first non singleton dimension.</item>
        /// <item> mean (A, D) where A is a N-D array of type 
        /// supported and D is s single scalar sized ILArray of type double or int: returnes 
        /// mean of elements of A along dimension dim.</item>
        /// </list></param>
        /// <param name="outParameters"> Output. Depending on the 
        /// length of A and on the type of its elements the output return value will be a single 
        /// ILBaseArray with mean of elements along dimension specified 
        /// or along first non singleton dimension. The type of the single ILArray 
        /// returned will be the same as the underlying type of A.</param>
        /// <remarks> This function is supported for all numeric arrays: /*!HC:ENUM:inCls1:*/ <![CDATA[ ILArray<complex>, ILArray<byte>]]> /*!HC:/ENUM*/. 
        /// It does return a <![CDATA[ILArray<BaseT>]]> for all input arrays, where BaseT is the inner
        /// type of the input array.
        /// </remarks>
        public static void mean(ILBaseArray[] outParameters, params ILBaseArray[] inParameters) {
            if (outParameters.Length != 1) 
                throw new ILArgumentNumberException ("Mean: one output parameter expected.");
            switch (inParameters.Length) {
                case 0:
                    throw new ILArgumentNumberException("mean: too less arguments specified.");
                case 1:
                    if (false) {
                    #region HYCALPER LOOPSTART 
                    } else if (inParameters[0] is /*!HC:inCls1*/ ILArray<double> ) { 
                        outParameters[0] = BuiltInFunctions.ILMath.mean((/*!HC:inCls1*/ ILArray<double> ) inParameters[0]);
                    #endregion HYCALPER LOOPEND
#region HYCALPER AUTO GENERATED CODE
// DO NOT EDIT INSIDE THIS REGION !! CHANGES WILL BE LOST !! 
                    } else if (inParameters[0] is  ILArray<byte> ) { 
                        outParameters[0] = BuiltInFunctions.ILMath.mean(( ILArray<byte> ) inParameters[0]);
                    } else if (inParameters[0] is  ILArray<complex> ) { 
                        outParameters[0] = BuiltInFunctions.ILMath.mean(( ILArray<complex> ) inParameters[0]);

#endregion HYCALPER AUTO GENERATED CODE
                    } else 
                        throw new ILArgumentTypeException("Mean is not defined for arrays of type " + inParameters[0].GetType().Name);
                    break; 
                case 2:
                    double dimensionArg = 0.0; 
                    if (!inParameters[1].IsScalar) {
                        throw new ILArgumentSizeException("mean: dimension argument must be positiv and scalar!"); 
                    }
                    if (false) {
                    #region HYCALPER LOOPSTART 
                    } else if (inParameters[1] is /*!HC:inCls1*/ ILArray<double> ) {
                            dimensionArg = (double) ((/*!HC:inCls1*/ ILArray<double> )inParameters[1]).GetValue(0,0);
                    #endregion HYCALPER LOOPEND 
#region HYCALPER AUTO GENERATED CODE
// DO NOT EDIT INSIDE THIS REGION !! CHANGES WILL BE LOST !! 
                    } else if (inParameters[1] is  ILArray<byte> ) {
                            dimensionArg = (double) (( ILArray<byte> )inParameters[1]).GetValue(0,0);
                    } else if (inParameters[1] is  ILArray<complex> ) {
                            dimensionArg = (double) (( ILArray<complex> )inParameters[1]).GetValue(0,0);

#endregion HYCALPER AUTO GENERATED CODE
                    } else  
                        throw new ILArgumentTypeException ("mean: dimension argument must be positiv and scalar!");
                    if (false) {
                    #region HYCALPER LOOPSTART 
                    } else if (inParameters[0] is /*!HC:inCls1*/ ILArray<double> ) { 
                        outParameters[0] = BuiltInFunctions.ILMath.mean((/*!HC:inCls1*/ ILArray<double> ) inParameters[0], (int) dimensionArg);
                    #endregion HYCALPER LOOPEND
#region HYCALPER AUTO GENERATED CODE
// DO NOT EDIT INSIDE THIS REGION !! CHANGES WILL BE LOST !! 
                    } else if (inParameters[0] is  ILArray<byte> ) { 
                        outParameters[0] = BuiltInFunctions.ILMath.mean(( ILArray<byte> ) inParameters[0], (int) dimensionArg);
                    } else if (inParameters[0] is  ILArray<complex> ) { 
                        outParameters[0] = BuiltInFunctions.ILMath.mean(( ILArray<complex> ) inParameters[0], (int) dimensionArg);

#endregion HYCALPER AUTO GENERATED CODE
                    } else 
                        throw new ILArgumentTypeException("Mean is not defined for arrays of type " + inParameters[0].GetType().Name);
                    break; 
                default:
                    throw new ILArgumentNumberException("mean: too many arguments specified.");
            }
        }
    }
}
