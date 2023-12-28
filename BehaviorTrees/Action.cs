using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviorTrees;

public class Action : TreeNode {
    private Func<NodeStatus> func;
    public Action(string name, Func<NodeStatus> func) : base(name) {
        this.func = func;
    }

    public override NodeStatus Tick() {
        return func();
    }
}
