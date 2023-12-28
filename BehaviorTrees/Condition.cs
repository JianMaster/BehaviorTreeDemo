using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviorTrees;

public class Condition : TreeNode {
    public Condition(string name) : base(name) {
    }

    public override NodeStatus Tick() {
        throw new NotImplementedException();
    }
}
