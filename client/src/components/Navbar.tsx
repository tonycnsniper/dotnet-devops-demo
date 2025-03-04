import { Avatar, Menubar } from "radix-ui";

export default function Navbar() {
  return (
    <div className="bg-gray-800">
      <div className="relative flex h-16 items-center justify-between mx-auto max-w-7xl px-2">
          <Menubar.Root className="absolute flex items-center grid-flow-row gap-6">
            
          <Menubar.Menu>
              <Menubar.Trigger className="relative inline-flex items-center justify-center text-gray-400">
                <Avatar.Root className="flex shrink-0 items-center">
                  <Avatar.Image 
                    className="h-8 w-auto"
                    src="https://tailwindui.com/plus-assets/img/logos/mark.svg?color=indigo&shade=500"
                    alt="Colm Tuite"
                  />
                </Avatar.Root>
              </Menubar.Trigger>
            </Menubar.Menu>
            
            <Menubar.Menu>
              <Menubar.Trigger className="relative inline-flex items-center justify-center text-gray-400">Home</Menubar.Trigger>
            </Menubar.Menu>

            <Menubar.Menu>
              <Menubar.Trigger className="relative inline-flex items-center justify-center text-gray-400">Threater</Menubar.Trigger>
            </Menubar.Menu>

            <Menubar.Menu>
              <Menubar.Trigger className="relative inline-flex items-center justify-center  text-gray-400">Movie</Menubar.Trigger>
            </Menubar.Menu>

            <Menubar.Menu>
              <Menubar.Trigger className="relative inline-flex items-center justify-center  text-gray-400"></Menubar.Trigger>
            </Menubar.Menu>
          </Menubar.Root>
        </div>
      </div>
  );
}
