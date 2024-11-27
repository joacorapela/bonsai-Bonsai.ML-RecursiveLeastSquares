using System;
using MathNet.Numerics.LinearAlgebra;

namespace Bonsai.ML.RecursiveLeastSquares
{
    public class RLSdataItem
    {
        public Vector<double> w;
        public Matrix<double> P;
    }
}
