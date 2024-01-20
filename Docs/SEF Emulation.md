# SEF Emulation<br><sup>This is all you need to know about the SEF semi-virtual CPU.</sup>

Now, while SEF is technically under an emulation but it's mostly not true as most functions just refer out of the CPU. The entire "CPU" is just a set of registers and stacks put into one place, and the entire CPU is based on 16 bit internals so you can use upto all 16 bit registers.

## Registers:
### General Registers:
- AX
- BX
- CX
- DX
### Others that just act as data holding registers and can be more like variables (even though that's not what they are meant for):
- SI
- DI
- SP
- BP
- CS
- DS
- SS
- ES
<br>(IP register has been removed as it's useless)

```
Now, you might question why I have decided to make all different data frames and stack pointing registers into plain variable-like registers, well....... I am too god damn lazy to make it that deep in as an emulator. I don't know, screw this.
```

Definetely, with all these registers you must have something to do with these, so, the general registers here are instead use to do everything other than data-storing, for that there is a table that shows all possible ways to do stuff with this "emulator". And to cut it off, you have a main `ax` register that has a hex number corresponding to the one that is for your specific action and then the `bx` register is used to pass the first argument and same for `cx` and `dx`. So if you want to send text to standard output (in this case into the console buffer) then you put the hex value for that instruction into `ax`, set `bx` to 0 as the buffer 0 is the main console buffer and then set `cx` for arguments.

There is a plan to make a stack system although its nowhere near to be there yet, so... here are the plans for it:
1) The stack is going to be at max holding 5 hex values at a time.
2) It must and MUST hold only 5 hex values (by default 0x0) or 5 pointers to other registers/hex memory values (that is references with * in the beginning, looking like `*0x64`).
3) The five values it will hold will be cleared if request for a StackClear instruction (that is being planned to added in SEF instructions)
4) The stack will be able to have push and pop functions that push and pop values/hex values to and fro actual registers and hex memory values.
5) The pop & push functions if not specified where to push or pop, will be default return to the `dx` register as most SEF action parameters don't have values till `dx` hence making it still good, although you may want to avoid doing it often as the `dx` register will have a lot of functionality at some point.
