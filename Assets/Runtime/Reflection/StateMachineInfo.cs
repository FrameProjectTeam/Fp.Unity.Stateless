using System;
using System.Collections.Generic;
using System.Linq;

namespace Fp.Utility.Stateless.Reflection
{
    /// <summary>
    ///     An info object which exposes the states, transitions, and actions of this machine.
    /// </summary>
    public class StateMachineInfo
    {
        internal StateMachineInfo(IEnumerable<StateInfo> states, Type stateType, Type triggerType, StateInfo initialState)
        {
            InitialState = initialState;
            States = states?.ToList() ?? throw new ArgumentNullException(nameof(states));
            StateType = stateType;
            TriggerType = triggerType;
        }

        /// <summary>
        ///     Exposes the initial state of this state machine.
        /// </summary>

        public StateInfo InitialState { get; }

        /// <summary>
        ///     Exposes the states, transitions, and actions of this machine.
        /// </summary>

        public IEnumerable<StateInfo> States { get; }

        /// <summary>
        ///     The type of the underlying state.
        /// </summary>
        /// <returns></returns>
        public Type StateType { get; }

        /// <summary>
        ///     The type of the underlying trigger.
        /// </summary>
        /// <returns></returns>
        public Type TriggerType { get; }
    }
}