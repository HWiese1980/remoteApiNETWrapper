using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace remoteApiNETWrapper
{
    public static class VREPWrapper
    {
#if MONO
        [DllImport("remoteApi.so")]
#else
        [DllImport("remoteApi.dll")]
#endif
        public static extern void simxFinish(int clientID);

#if MONO
        [DllImport("remoteApi.so")]
#else
        [DllImport("remoteApi.dll")]
#endif
        public static extern int simxGetConnectionId(int clientID);

#if MONO
        [DllImport("remoteApi.so")]
#else
        [DllImport("remoteApi.dll")]
#endif
        public static extern simx_error simxGetStringSignal(int clientID, string signalName, ref IntPtr pointerToValue, ref int signalLength, simx_opmode opmode);
        
#if MONO
        [DllImport("remoteApi.so")]
#else
        [DllImport("remoteApi.dll")]
#endif
        public static extern simx_error simxGetAndClearStringSignal(int clientID, string signalName, ref IntPtr pointerToValue, ref int signalLength, simx_opmode opmode);

#if MONO
        [DllImport("remoteApi.so")]
#else
        [DllImport("remoteApi.dll")]
#endif
        public static extern simx_error simxGetJointPosition(int clientID, int jointHandle, ref float targetPosition, simx_opmode opmode);

#if MONO
        [DllImport("remoteApi.so")]
#else
        [DllImport("remoteApi.dll")]
#endif
        public static extern simx_error simxGetObjectIntParameter(int clientID, int objectHandle, int parameterID, ref int parameterValue, simx_opmode opmode);

#if MONO
        [DllImport("remoteApi.so")]
#else
        [DllImport("remoteApi.dll")]
#endif
        public static extern simx_error simxGetObjectFloatParameter(int clientID, int objectHandle, int parameterID, ref float parameterValue, simx_opmode opmode);

#if MONO
        [DllImport("remoteApi.so")]
#else
        [DllImport("remoteApi.dll")]
#endif
        public static extern simx_error simxGetObjectOrientation(int clientID, int jointHandle, int relativeToHandle, float[] orientations, simx_opmode opmode);

#if MONO
        [DllImport("remoteApi.so")]
#else
        [DllImport("remoteApi.dll")]
#endif
        public static extern simx_error simxGetObjectPosition(int clientID, int jointHandle, int relativeToHandle, float[] positions, simx_opmode opmode);

#if MONO
        [DllImport("remoteApi.so")]
#else
        [DllImport("remoteApi.dll")]
#endif
        public static extern simx_error simxPauseCommunication(int cliendID, int pause);

#if MONO
        [DllImport("remoteApi.so")]
#else
        [DllImport("remoteApi.dll")]
#endif
        public extern static simx_error simxReadProximitySensor(int clientID, int sensorHandle,
                                                         ref char detectionState, float[] detectionPoint, ref int objectHandle, float[] normalVector, simx_opmode opmode);

#if MONO
        [DllImport("remoteApi.so")]
#else
        [DllImport("remoteApi.dll")]
#endif
        public static extern simx_error simxSetJointTargetPosition(int clientID, int jointHandle, float targetPosition, simx_opmode opmode);

#if MONO
        [DllImport("remoteApi.so")]
#else
        [DllImport("remoteApi.dll")]
#endif
        public static extern simx_error simxSetJointTargetVelocity(int clientID, int jointHandle, float velocity, simx_opmode opmode);

#if MONO
        [DllImport("remoteApi.so")]
#else
        [DllImport("remoteApi.dll")]
#endif
        public static extern simx_error simxSetObjectFloatParameter(int clientID, int objectHandle, int parameterID, float parameterValue, simx_opmode opmode);

#if MONO
        [DllImport("remoteApi.so")]
#else
        [DllImport("remoteApi.dll")]
#endif
        public static extern simx_error simxSetObjectIntParameter(int clientID, int objectHandle, int parameterID, int parameterValue, simx_opmode opmode);

#if MONO
        [DllImport("remoteApi.so")]
#else
        [DllImport("remoteApi.dll")]
#endif
        public static extern int simxStart(string ip, int port, bool waitForConnection, bool reconnectOnDisconnect, int timeoutMS, int cycleTimeMS);
    }
}