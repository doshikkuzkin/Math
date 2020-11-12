using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Unity.PerformanceTesting;

namespace Tests
{
    public class SqrMagnitudeTest
    {
        [Test, Performance]
        public void SqrMagnitudeSpeedTest()
        {
            Measure.Method(() => sqrMagnitude())
                .WarmupCount(10)
                .MeasurementCount(1000)
                .Run();
        }
        
        [Test, Performance]
        public void DistanceSpeedTest()
        {
            Measure.Method(() => distance())
                .WarmupCount(10)
                .MeasurementCount(1000)
                .Run();
        }

        private static float distance()
        {
            return Vector3.Distance(v1, v2);
        }

        private static float sqrMagnitude()
        {
            return Vector3.SqrMagnitude(v2 - v1);
        }
        
        private static Vector3 v1 => new Vector3(Random.value, Random.value, Random.value);
        private static Vector3 v2 => new Vector3(Random.value, Random.value, Random.value);
    }
}
