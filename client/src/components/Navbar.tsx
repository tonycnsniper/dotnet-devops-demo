import { Container, TabNav } from "@radix-ui/themes";


export default function Navbar() {
  return (
    <TabNav.Root justify="start" className="shadow-none">
      <TabNav.Link href="#" active>
        Home
      </TabNav.Link>
      <TabNav.Link href="#">Threater</TabNav.Link>
      <TabNav.Link href="#">Movie</TabNav.Link>
    </TabNav.Root>
  );
}
