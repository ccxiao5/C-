using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace experiment_2
{
    public class Players //对外访问权限设置为public要不然会访问失败
    {
        private String namePlayer;
        private String id;
        private double[] goal;
        private double Goal;//选手最终得分
        private double maxGoal,minGoal;//选手的最高分合最低分
        public Players(String namePlayer, String id)
        {
            this.namePlayer = namePlayer;
            this.id = id;
        }
        public void setName(String namePlayer)//设置选手姓名
        {
             this.namePlayer=namePlayer;
        }
        public void setId(String id)//设置选手编号
        {
            this.id=id;
        }
        public String getName()//返回选手姓名
        {
            return namePlayer;
        }
        public String getId()//返回选手编号
        {
            return id;
        }
        public double getMaxGoal()//返回选手最大成绩
        {
            return this.maxGoal;
        }
        public double getMinGoal()//返回选手最大成绩
        {
            return this.minGoal;
        }
        public double getFinalGoal()//返回选手最终成绩
        {
            return this.Goal;
        }
        public void resetGoal(int i, double m)//修改分数
        {
            this.goal[i] = m;
        }
        public double outputGoal(int i)//输出指定位置分数
        {
            return this.goal[i];
        }
        public double[] showGoal()//返回选手成绩
        {
            return this.goal;
        }
        public void getGoal(double[] goal)//得到选手最高分最低分以及最终分数
        {
            int i;
            this.goal = new double[goal.Length];
            double max = -1.0,min = 101.0;
            double Sum = 0;
            for (i = 0; i < goal.Length; i++)
            {
                this.goal[i] = goal[i];
                if (goal[i] < min)
                    min = goal[i];
                if (goal[i] > max)
                    max = goal[i];
                Sum += goal[i];
            }
            maxGoal = max;
            minGoal = min;
            Goal = (Sum - maxGoal - minGoal) / (double)(goal.Length-2);
        }
    }
}
