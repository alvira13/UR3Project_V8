/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.CartesianControl
{
    public class CartesianTolerance : Message
    {
        public const string RosMessageName = "cartesian_control_msgs/CartesianTolerance";

        public Vector3 position_error { get; set; }
        public Vector3 orientation_error { get; set; }
        public Twist twist_error { get; set; }
        public Accel acceleration_error { get; set; }

        public CartesianTolerance()
        {
            this.position_error = new Vector3();
            this.orientation_error = new Vector3();
            this.twist_error = new Twist();
            this.acceleration_error = new Accel();
        }

        public CartesianTolerance(Vector3 position_error, Vector3 orientation_error, Twist twist_error, Accel acceleration_error)
        {
            this.position_error = position_error;
            this.orientation_error = orientation_error;
            this.twist_error = twist_error;
            this.acceleration_error = acceleration_error;
        }
    }
}
