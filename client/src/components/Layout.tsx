import { ReactNode } from "react";
import Navbar from "./Navbar";

type Props = {
  children: ReactNode;
};

export default function Layout({ children }: Props) {
  return (
    <>
      <Navbar />
      <div className="container pt-16">
        <div className="inner container max-w-screen-md mx-auto pt-2">
          {children}
        </div>
      </div>
    </>
  );
}
