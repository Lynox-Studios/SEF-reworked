# Understanding SEF

## Index
- Chapter 01: What is SEF?
- Chapter 02: SEF as an actual thing.
- Chapter 03: SEF CPU Fundamentals.
- Chapter 04: SEF Parser
- Chapter 05: SEF ActionPerformer
- Chapter 06: Low-level interpreter theory
- Chapter 07: Libraries
- Chapter 08: Is it usable for further layers of development?
- Chapter 09: Structure of pre-byte.
- Chapter 10: Advancing via Assemblers & Compilers (Coming soon)
- Chapter 11: Above and Beyond (Coming soon)
- Chapter 12: Kernel Offloading (Coming soon)
- Chapter 13: Bootstrapping SEF (Coming soon)
- Chapter 14: Porting Linux/UNIX programs (Coming soon)
- Chapter 15: Pre-byte deep-down (Coming soon)


## What is SEF?<br><sup>CHAPTER 1</sup>
SEF should be clear by now that it is an executable format (sort of that is) and it stands for Simple Executable Format, it may be considered false advertising because SEF unlike other formats, just uses simple low-level-like interpreter code under the hexstring format, so that means the exeuctor just takes the code, makes it backs to string and then interprets it under a semi-virtual CPU.<br>
Now, SEF as a structure is divided down to 2 main concepts, the parser and performer (a.k.a actionperformer) and a simple thing you may want to know is that the parser takes your string version of executable code, and puts it in a list of actions that can be later directly applied via the performer, the performer is nothing but a list of actions that is executed all at once on the virtual CPU via the help of basic registers and kernel pointers, so if you want to view a file you can call the kernel for it than sending all files from kernel to virtual CPU.


## SEF as an actual thing.<br><sup>CHAPTER 2</sup>
SEF actually somehow does make sense to develop upon as it really is just a set of pre-defined simple instructions, now as of right now you cannot directly add/subtract/multiply/divide or do any arithmetic equations but it is yet to change with the introduction of a SEF Assembler, that will allow to do equations and all and surely make it far more intuitive than pre-byte code is today.<br>
The point of view of a programmer too, the SEF is quite the win for minimal kernels written with C# (being under the Cosmos/MOSA project, etc.) because its really just your first core level, the thing is there is no too much pre-defined things in SEF that make it aimed towards a certain single type of execution, its really like your kernel interacting software and to be fair, SEF is actually useful when trying to bootstrap the kernel which is basically a process of offloading kernel off to the filesystem and executing it, its quite the challenge but with steady growth of SEF development its 100% possible in all sense.
Lastly, SEF may become a gigantic porting machine, see as of righting this "book"/manual I have just barely made any progress in SEF but the plans and calculations say that if the assembler is powerful enough it can be made to port over the GNU C Compiler, now hear me out its definetely the biggest challenge of the entire C# history but it is possible because it is not that hard to make the GAS syntax to SEF Assembly syntax conversion and porting is quite the easiest part if the GAS syntax perfectly matches with GNU Assembly. Again, this is nowhere near done or started yet but it is definetely possible to get atleast the basic core parts of C down in SEF and this may be the biggest jackpot because porting a simple C compiler means that while it may take the most fucking shit ton of time to compile anything in that C compiler, it may become really easy to with patience, port over every single programming languages of the entire world, or atleast the main ones... Such as the original CPython implementation and possibly even C++. Now, let's come back from the dreams and wait to see the result.


## SEF CPU Fundamentals.<br><sup>CHAPTER 3</sup>
The fundamentals are pretty complicated of the SEF "virtual" CPU as its not really "virtual" but instead a sandboxed way of running programs.. To learn more about it, its given in far more detail on the [SEF Emulation wiki](./SEF%20Emulation.md).
To be short, its a 16 bit emulator with all 16 bit registers except that non-general registers just act as a regular registers, it also has base functions used for pointing at the kernel or to put it simply it has action pointers so its not really a virtual CPU but more like a virtual data holder.
