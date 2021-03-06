﻿#region Copyright (c) 2011--, Benoit PATRA <benoit.patra (AT) gmail (DOT) com> and Matthieu Durut <durut.matthieu (AT) gmail (DOT) com>
// This code is released under the terms of the new BSD licence.
// URL: http://code.google.com/p/clouddalvq/
#endregion

using System.Runtime.Serialization;

namespace CloudDALVQ.DataGenerator
{
    /// <summary>
    /// Interface for random generators that produce data samples.
    /// </summary>
    public interface IGenerator
    {
        double[][] GetData(int dataCount);

        double[] Next();
    }
}
